namespace JobDataEstimada.Models;
public class Demanda
{
    public Demanda()
    { }
    public Demanda(string? descricao, int horaEstimada)
    {
        Descricao = descricao;
        HoraEstimada = horaEstimada;
    }

    public string? Descricao { get; set; }
    public int HoraEstimada { get; set; }
    public DateTime? DataEstimada { get; set; }

    public void Cadastrar()
    {
        Descricao = Guid.NewGuid().ToString();
        HoraEstimada = new Random().Next(1, 20);

        //Console.Write("Demanda: ");
        //Descricao = Console.ReadLine();
        //Console.Write("Horas estimadas: ");
        //HoraEstimada = Convert.ToInt32(Console.ReadLine());
    }
}

