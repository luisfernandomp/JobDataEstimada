using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDataEstimada.Models
{
    public class Entrega
    {
        public Entrega(DateTime data, int[] demanda)
        {
            Data = data;
            Demanda = demanda;
        }

        public DateTime Data { get; set; }
        public int[] Demanda { get; set; }

    }
}
