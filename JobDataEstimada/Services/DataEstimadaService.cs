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
        while(data != sprint.DataFim)
        {
            if (sprint.DaysOff.Contains(data))
            {
                data = data.AddDays(1);
                continue;
            }

            if (FinalSemana.Contains(data.DayOfWeek))
            {
                data = data.AddDays(1);
                continue;
            }

            data = data.AddDays(1);
            DatasDisponiveis.Add(data);
        }

        Console.WriteLine("Datas disponíveis: ");
        Console.Write(string.Join(", ", DatasDisponiveis));

        return DatasDisponiveis;
    }

    public void CalcularDataEstimada(List<Demanda> demanda)
    {

    }
}
