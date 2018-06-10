using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletosAutolavado.Data
{
    public class Car
    {
        public Car()
        {
            this.id = 0;
            this.placa = string.Empty;
            this.entrada = DateTime.Now;
            this.salida = DateTime.Now;
            this.duracion = TimeSpan.FromSeconds(0);
            this.costoPrimeraHora = 0;
            this.costoPorHora = 0;
            this.pago = 0;
            this.codigo = string.Empty;
        }

        public int id { get; set; }
        public string placa { get; set; }
        public DateTime entrada { get; set; }
        public DateTime salida { get; set; }
        public TimeSpan duracion { get; set; }
        public double costoPrimeraHora { get; set; }
        public double costoPorHora { get; set; }
        public double pago { get; set; }
        public string codigo { get; set; }
    }
}
