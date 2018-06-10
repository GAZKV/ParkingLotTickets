using BoletosAutolavado.Aplication;
using BoletosAutolavado.Bussines;
using BoletosAutolavado.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoletosAutolavado
{
    public partial class Principal : Form
    {

        private DateTime time;

        private Car ultimoVendido;
        private Cars activos; 
        private Cars vendidos;
        private Prices costo;
        private Serials seriales;

        static string rutaActivos = "./Data/Act.bin";
        static string rutaVendidos = "./Data/Sel.bin";
        static string rutaCostos = "./Data/Pri.bin";
        string rutaSeriales = "./Data/Ser.bin";

        DateTime tiempoTranscurrido;

        public Principal()
        {
            ultimoVendido = new Car();
            time = DateTime.Now;
            tiempoTranscurrido = time;
            rutaSeriales = "./Data/Ser_" + time.ToString("dd_MM_yyyy") + ".bin";

            activos = readCarrosActivos();
            vendidos = readVendidos();
            costo = readCostos();
            seriales = readSeriales();

            InitializeComponent();
            tmrReloj.Start();

            cargarActivosLista();
            cargarVendidosLista();
        }

        private Serials readSeriales()
        {
            return new Files().loadSerials(rutaSeriales);
        }

        private Prices readCostos()
        {
            return new Files().loadTarifa(rutaCostos);
        }

        private Cars readVendidos()
        {
            return new Files().loadCars(rutaVendidos);
        }

        private Cars readCarrosActivos()
        {
            return new Files().loadCars(rutaActivos);
        }

        private void cargarActivosLista()
        {
            List<string> activos_lista = new List<string>();
            foreach (Car item in activos.cars)
            {
                item.salida = time;
                item.duracion = item.salida - item.entrada;
                activos_lista.Add(item.id + "; " + item.entrada.ToString("HH:mm:ss") + " Auto: " + item.placa + " - $" + getPrice(item.duracion));
            }

            lbActivos.DataSource = activos_lista;

        }

        private void cargarVendidosLista()
        {
            List<string> vendidos_lista = new List<string>();
            var query = from u in vendidos.cars where u.salida > time.Date select u;
            foreach (Car item in query)
            {
                vendidos_lista.Add(item.id + "; " + item.salida.ToString("HH:mm:ss") + " Auto: " + item.placa + " - $" + item.pago);
            }

            lbVendidos.DataSource = vendidos_lista;

        }

        private double getPrice(TimeSpan duracion)
        {
            double precio = 0;
            if (duracion.TotalHours > 1)
            {
                if (Math.Truncate(duracion.TotalHours) == 1)
                {
                    precio = costo.costoPrimeraHora;
                    precio += (duracion.Minutes > 10) ? costo.costoPorHora : 0;
                }
                else
                {
                    precio = costo.costoPrimeraHora;
                    precio += (Math.Truncate(duracion.TotalHours) - 1) * costo.costoPorHora;
                    precio += (duracion.Minutes > 10) ? costo.costoPorHora : 0;
                }
            }
            else
            {
                precio = costo.costoPrimeraHora;
            }
            return precio;
        }

        private void guardarActivos()
        {
            new Files().saveCars(rutaActivos, activos);
        }

        private void guardarVendidos()
        {
            new Files().saveCars(rutaVendidos, vendidos);
        }

        private void guardarSeriales()
        {
            new Files().saveSerials(rutaSeriales, seriales);
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            lblRelojPrincipal.Text =
                time.ToString("dd-MM-yyyy") + "\n" +
                time.ToString("HH:mm:ss");

            if ((time - tiempoTranscurrido).TotalMinutes > 10)
            {
                cargarActivosLista();
                tiempoTranscurrido = time;
            }

        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            Car nuevoAuto = new Car();
            nuevoAuto.id = activos.cars.Count + 1;
            nuevoAuto.placa = (txtPlacas.Text != string.Empty) ? txtPlacas.Text : "CAR" + nuevoAuto.id;
            nuevoAuto.entrada = time;
            nuevoAuto.salida = time;
            nuevoAuto.costoPrimeraHora = costo.costoPrimeraHora;
            nuevoAuto.costoPorHora = costo.costoPorHora;
            seriales.serial.Add(seriales.serial.Count);

            nuevoAuto.codigo =
                "586" + 
                time.DayOfYear.ToString("000") +
                seriales.serial.Last().ToString("000");

            activos.cars.Add(nuevoAuto);
            guardarSeriales();
            guardarActivos();

            cargarActivosLista();

            txtPlacas.Text = string.Empty;

            printTicketLavado.Print();
        }
        
        private void btnPayout_Click(object sender, EventArgs e)
        {
            Venta formVenta = new Venta();

            DialogResult respuesta = formVenta.ShowDialog();
            string ticketCode = formVenta.ticketLectura;

            Car busqueda = new Car();

            if (respuesta == DialogResult.OK)
            {
                busqueda = (from u in activos.cars where u.codigo == ticketCode select u).FirstOrDefault();
                
                if (busqueda != null)
                {
                    ultimoVendido = busqueda;

                    busqueda.salida = time;
                    busqueda.duracion = busqueda.salida - busqueda.entrada;
                    busqueda.pago = getPrice(busqueda.duracion);

                    activos.cars.Remove(busqueda);
                    vendidos.cars.Add(busqueda);

                    guardarActivos();
                    guardarVendidos();

                    printTicketRecibo.Print();

                    cargarActivosLista();
                    cargarVendidosLista();
                }
                else
                {
                    MessageBox.Show(null, "Boleto no encontrado, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void printTicketLavado_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;

            string tiempo = time.ToString("dd/MM/yyyy") + "  " + time.ToString("HH:mm:ss");
            String impresion =
                "ESTACIONAMIENTO Y REFACCIONES" + "\n\n" +
                "\"LA TERMO\"" + "\n\n" +
                "2 de abril #105" + "\n" +
                "Entrada01" +
                "\n\n" +
                "TARIFA" + "\n" +
                "$" + costo.costoPrimeraHora + " PRIMERA HORA, " + "\n" +
                "$" + costo.costoPorHora + " HORA O FRACCION" + "\n" +
                "$100 PERDIDA DE TICKET," + "\n" +
                "MAS COMPROBACION DEL VEHICULO." + "\n\n" +
                "HORARIOS" + "\n" +
                "LUNES A SABADO DE 07:00 A 19:00";
            //"PLACAS: " + "GPA-96-10" + "\n" +

            string impresion2 = "ENTRADA: \n" + tiempo;
            String codigo = "*586" +
                time.DayOfYear.ToString("000") +
                seriales.serial.Last().ToString("000")+"*";

            e.Graphics.DrawString(impresion, new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular, GraphicsUnit.Pixel, 11, false), Brushes.Black, 100, 100, formato);
            e.Graphics.DrawString(impresion2, new Font(FontFamily.GenericSansSerif, 14, FontStyle.Regular, GraphicsUnit.Pixel, 11, false), Brushes.Black, 100, 220, formato);
            e.Graphics.DrawString(codigo, lblBarcode.Font, Brushes.Black, 100, 260, formato);
        }

        private void printTicketRecibo_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;

            string tiempo = time.ToString("dd/MM/yyyy") + "  " + time.ToString("HH:mm:ss");
            String impresion =
                "ESTACIONAMIENTO Y REFACCIONES" + "\n\n" +
                "\"LA TERMO\"" + "\n\n" +
                "2 de abril #105" + "\n" +
                "Entrada01" +
                "\n\n" +
                "TARIFA" + "\n" +
                "$" + ultimoVendido.costoPrimeraHora + " PRIMERA HORA, " + "\n" +
                "$" + ultimoVendido.costoPorHora + " HORA O FRACCION" + "\n" +
                "$100 PERDIDA DE TICKET," + "\n" +
                "MAS COMPROBACION DEL VEHICULO." + "\n\n" +
                "HORARIOS" + "\n" +
                "LUNES A SABADO DE 07:00 A 19:00";
            //"PLACAS: " + "GPA-96-10" + "\n" +

            string impresion2 =
                "ENTRADA: \n" +
                ultimoVendido.entrada + "\n\n" +
                "SALIDA: \n" +
                ultimoVendido.salida + "\n\n" +
                "DURACION: \n" +
                getFormatTimeSpan(ultimoVendido.duracion) + "\n" +
                "COSTO: " + ultimoVendido.pago;

            e.Graphics.DrawString(impresion, new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular, GraphicsUnit.Pixel, 11, false), Brushes.Black, 100, 100, formato);
            e.Graphics.DrawString(impresion2, new Font(FontFamily.GenericSansSerif, 14, FontStyle.Regular, GraphicsUnit.Pixel, 11, false), Brushes.Black, 100, 300, formato);
        }

        private string getFormatTimeSpan(TimeSpan ts)
        {
            if (ts.Days >= 1)
            {
                return string.Format("{0:%d}dias {0:%h}hrs {0:%m}min {0:%s}sec", ts);
            }
            else
            {
                if (ts.Hours >= 1)
                {
                    return string.Format("{0:%h}hrs {0:%m}min {0:%s}seg", ts);
                }
                else
                {
                    return string.Format("{0:%m}min {0:%s}seg", ts);
                }
            }
        }

        private void cobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car busqueda = new Car();
            int comparador = -1;

            if (lbActivos.SelectedItems.Count > 0 && lbActivos.SelectedIndex > -1)
            {
                comparador = int.Parse(lbActivos.SelectedValue.ToString().Split(';')[0]);
                busqueda = (from u in activos.cars where u.id == comparador select u).FirstOrDefault();

                if (busqueda != null)
                {
                    ultimoVendido = busqueda;

                    busqueda.salida = time;
                    busqueda.duracion = busqueda.salida - busqueda.entrada;
                    busqueda.pago = getPrice(busqueda.duracion);

                    activos.cars.Remove(busqueda);
                    vendidos.cars.Add(busqueda);

                    guardarActivos();
                    guardarVendidos();

                    printTicketRecibo.Print();

                    cargarActivosLista();
                    cargarVendidosLista();
                }
                else
                {
                    MessageBox.Show(null, "Boleto no encontrado, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
