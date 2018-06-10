using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoletosAutolavado.Aplication
{
    public partial class Venta : Form
    {

        public string ticketLectura { get; set; }

        public Venta()
        {
            InitializeComponent();
        }

        private void txtTicketCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCobrar.PerformClick();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
                ticketLectura = txtTicketCode.Text;
                this.DialogResult = DialogResult.OK;
        }
    }
}
