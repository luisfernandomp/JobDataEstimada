namespace JobDataEstimada.Models;

public class Sprint
{
    public Sprint()
    {
        DaysOff = new List<DateTime>();
        Desenvolvedor = new List<Desenvolvedor>();
        Demanda = new List<Demanda>();
        DiasDisponiveis = new List<DateTime>();
    }

    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public List<DateTime> DaysOff { get; set; }
    public List<DateTime> DiasDisponiveis { get; set; }
    public int CapacidadeTotal { get; set; }
    public int CapacidadePorDia { get; private set; }
    public int HorasMeta { get; set; }
    public int HorasGordura { get; set; }
    public List<Desenvolvedor> Desenvolvedor { get; set; }
    public List<Demanda> Demanda { get; set; }

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

    public void ExibirSprint()
    {
        Console.WriteLine($"\nHoras meta - {HorasMeta}");
        Console.WriteLine($"Horas gordura - {HorasGordura}");
        Console.WriteLine($"Capacidade total - {CapacidadeTotal}");
        Console.WriteLine($"Capacidade por dia - {CapacidadePorDia}");
    }

    public void Cadastrar()
    {
        Console.WriteLine("CADASTRO SPRINT");
        //Console.Write("Data início: ");
        //AdicionarDataInicio(Console.ReadLine() ?? "");
        //Console.Write("Data fim: ");
        //AdicionarDataFim(Console.ReadLine() ?? "");

        AdicionarDataInicio("17/01/2023");
        AdicionarDataFim("31/01/2023");

        CadastrarDesenvolvedores();
        CadastrarDemandas();
    }

    public void CadastrarDesenvolvedores()
    {
        Console.WriteLine("CADASTRO DESENVOLVEDORES");

        bool cadastrarTime = true;

        while (cadastrarTime)
        {
            var desenvolvedor = new Desenvolvedor();
            desenvolvedor.Cadastrar();
            Desenvolvedor.Add(desenvolvedor);

            Console.WriteLine("Continuar? S/N");
            if (Console.ReadLine()?.ToUpper() == "N")
            {
                cadastrarTime = false;
            }
        }
    }

    public void CadastrarDemandas()
    {
        Console.WriteLine("CADASTRO DEMANDAS");

        bool cadastrarDemanda = true;

        while (cadastrarDemanda)
        {
            var demanda = new Demanda();
            demanda.Cadastrar();
            Demanda.Add(demanda);

            Console.WriteLine("Continuar? S/N");
            if (Console.ReadLine()?.ToUpper() == "N")
            {
                cadastrarDemanda = false;
            }
        }
    }

    public void ObterCapacidadeTotal()
    {
        int datasDisponiveis = DiasDisponiveis.Count();
        CapacidadePorDia = Desenvolvedor
            .Select(x => x.CapacidadePorDia)
            .Sum();

        CapacidadeTotal = CapacidadePorDia * datasDisponiveis;
        ObterHorasGordura();
        ObterHorasMeta();
    }

    public void ObterHorasGordura()
    {
        HorasGordura = Convert.ToInt32(Math.Round(CapacidadeTotal * 0.2, 0));
    }

    public void ObterHorasMeta()
    {
        HorasMeta = CapacidadeTotal - HorasGordura;
    }


}
