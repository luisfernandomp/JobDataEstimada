using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDataEstimada.Models
{
    public class Time
    {
        public Time(string nome, int capacidadePorDia)
        {
            Nome = nome;
            CapacidadePorDia = capacidadePorDia;
            DayOff = new List<DateTime>();
        }

        public string Nome { get; set; }
        public int CapacidadePorDia { get; set; }
        public List<DateTime> DayOff { get; set; }

    }
}
