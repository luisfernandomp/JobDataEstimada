using JobDataEstimada.Models;
using System.Data;

namespace JobDataEstimada.Services;
public class DataEstimadaService
{
    private readonly DayOfWeek[] FinalSemana = new
        DayOfWeek[] { DayOfWeek.Sunday, DayOfWeek.Saturday };


    public List<DateTime> ObterDatasDisponiveis(Sprint sprint)
    {
        List<DateTime> DatasDisponiveis = new List<DateTime>();

        var data = sprint.DataInicio;
        while(data <= sprint.DataFim)
        {
            if (sprint.DaysOff.Contains(data) ||
                FinalSemana.Contains(data.DayOfWeek))
            {
                data = data.AddDays(1);
                continue;
            }

            DatasDisponiveis.Add(data);
            data = data.AddDays(1);
        }

        Console.WriteLine("Datas disponíveis: ");
        Console.Write(string.Join(", ", DatasDisponiveis));

        return DatasDisponiveis;
    }

    public void CalcularDataEstimada(ref Sprint sprint)
    {
        int horasDisponiveis = 0;

        foreach (var data in sprint.DiasDisponiveis)
        {
            horasDisponiveis += sprint.CapacidadePorDia;


            for (int i = 0; i < sprint.Demanda.Count(); i++)
            {
                if (sprint.Demanda[i].DataEstimada != null)
                    continue;

                if (horasDisponiveis < sprint.Demanda[i].HoraEstimada)
                    break;

                horasDisponiveis -= sprint.Demanda[i].HoraEstimada;

                if (horasDisponiveis >= 0)
                    sprint.Demanda[i].DataEstimada = data;
            }
        }
    }
}
