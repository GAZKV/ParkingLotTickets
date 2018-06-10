using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletosAutolavado.Data
{
    public class Prices
    {

        public Prices()
        {
            this.costoPrimeraHora = 12;
            this.costoPorHora = 8;
        }

        public double costoPrimeraHora { get; set; }
        public double costoPorHora { get; set; }
    }
}
