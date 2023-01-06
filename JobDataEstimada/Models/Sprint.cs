namespace JobDataEstimada.Models;

public class Sprint
{
    public Sprint()
    {
        DaysOff = new List<DateTime>();
    }

    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public List<DateTime> DaysOff { get; set; }

    public void AdicionarDataFim(string data)
    {
        DateTime dataFim = new DateTime();
        if (DateTime.TryParse(data, out dataFim))
            DataFim = dataFim;
    }
    public void AdicionarDataInicio(string data)
    {
        DateTime dataInicio = new DateTime();
        if (DateTime.TryParse(data, out dataInicio))
            DataInicio = dataInicio;
    }

    public void AdicionarDayOff(string data)
    {
        DateTime dayOff = new DateTime();
        if (DateTime.TryParse(data, out dayOff))
            DaysOff.Add(dayOff);
    }
}
