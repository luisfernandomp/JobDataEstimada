
using JobDataEstimada.Models;
using JobDataEstimada.Services;

var sprint = new Sprint();
var service = new DataEstimadaService();


sprint.Cadastrar();

var datasDisponiveis = service.ObterDatasDisponiveis(sprint);
sprint.DiasDisponiveis = datasDisponiveis;
sprint.ObterCapacidadeTotal();
Console.Clear();
sprint.ExibirSprint();

service.CalcularDataEstimada(ref sprint);

Console.Write("\n");

foreach (var item in sprint.Demanda.OrderBy(x => x.DataEstimada).ToList())
{
    Console.WriteLine($"{item.Descricao} - {item.DataEstimada.ToString()}");
}



























