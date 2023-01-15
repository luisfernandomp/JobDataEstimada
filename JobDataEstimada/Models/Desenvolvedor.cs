using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDataEstimada.Models
{
    public class Desenvolvedor
    {
        public Desenvolvedor(string nome, int capacidadePorDia)
        {
            Nome = nome;
            CapacidadePorDia = capacidadePorDia;
            DayOff = new List<DateTime>();
        }

        public Desenvolvedor() 
        {
            
        }

        public string Nome { get; set; }
        public int CapacidadePorDia { get; set; }
        public List<DateTime> DayOff { get; set; }

        public void Cadastrar()
        {
            Nome = Guid.NewGuid().ToString();
            CapacidadePorDia = new Random().Next(1, 7);
            //Console.Write("Nome: ");
            //Nome = Console.ReadLine() ?? "";
            //Console.Write("Capacidade: ");
            //CapacidadePorDia = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("DayOff: ");
            //DayOff.Add(Convert.ToDateTime(Console.ReadLine() ?? DateTime.Now.ToString()));
        }

    }
}
