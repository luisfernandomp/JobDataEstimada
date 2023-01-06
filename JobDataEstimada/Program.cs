
using JobDataEstimada.Models;
using JobDataEstimada.Services;

var sprint = new Sprint();
var service = new DataEstimadaService();

Console.WriteLine("Data início: ");
sprint.AdicionarDataInicio(Console.ReadLine() ?? "");
Console.WriteLine("Data fim: ");
sprint.AdicionarDataFim(Console.ReadLine() ?? "");


service.ObterDatasDisponiveis(sprint);























