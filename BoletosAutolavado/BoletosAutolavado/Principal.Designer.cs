namespace BoletosAutolavado
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbActivos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrintTicket = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbVendidos = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.btnPayout = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblRelojPrincipal = new System.Windows.Forms.Label();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.printTicketLavado = new System.Drawing.Printing.PrintDocument();
            this.printTicketRecibo = new System.Drawing.Printing.PrintDocument();
            this.cmsCobrarActivo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.cmsCobrarActivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbActivos
            // 
            this.lbActivos.ContextMenuStrip = this.cmsCobrarActivo;
            this.lbActivos.FormattingEnabled = true;
            this.lbActivos.ItemHeight = 29;
            this.lbActivos.Location = new System.Drawing.Point(14, 28);
            this.lbActivos.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbActivos.Name = "lbActivos";
            this.lbActivos.Size = new System.Drawing.Size(405, 526);
            this.lbActivos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbActivos);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Size = new System.Drawing.Size(433, 571);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autos estacionados";
            // 
            // btnPrintTicket
            // 
            this.btnPrintTicket.Location = new System.Drawing.Point(10, 37);
            this.btnPrintTicket.Name = "btnPrintTicket";
            this.btnPrintTicket.Size = new System.Drawing.Size(238, 85);
            this.btnPrintTicket.TabIndex = 2;
            this.btnPrintTicket.Text = "Entrada";
            this.btnPrintTicket.UseVisualStyleBackColor = true;
            this.btnPrintTicket.Click += new System.EventHandler(this.btnPrintTicket_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbVendidos);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(735, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox2.Size = new System.Drawing.Size(433, 571);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autos pagados hoy";
            // 
            // lbVendidos
            // 
            this.lbVendidos.FormattingEnabled = true;
            this.lbVendidos.ItemHeight = 29;
            this.lbVendidos.Location = new System.Drawing.Point(14, 28);
            this.lbVendidos.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbVendidos.Name = "lbVendidos";
            this.lbVendidos.Size = new System.Drawing.Size(405, 526);
            this.lbVendidos.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblBarcode);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtPlacas);
            this.groupBox3.Controls.Add(this.btnPayout);
            this.groupBox3.Controls.Add(this.btnPrintTicket);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(463, 159);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox3.Size = new System.Drawing.Size(258, 427);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Autos";
            // 
            // lblBarcode
            // 
            this.lblBarcode.BackColor = System.Drawing.Color.Gray;
            this.lblBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBarcode.Font = new System.Drawing.Font("Free 3 of 9", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcode.Location = new System.Drawing.Point(10, 195);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(238, 42);
            this.lblBarcode.TabIndex = 1;
            this.lblBarcode.Text = "ECEL000001";
            this.lblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "PLACAS:";
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(10, 157);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(238, 35);
            this.txtPlacas.TabIndex = 4;
            // 
            // btnPayout
            // 
            this.btnPayout.Location = new System.Drawing.Point(10, 240);
            this.btnPayout.Name = "btnPayout";
            this.btnPayout.Size = new System.Drawing.Size(238, 85);
            this.btnPayout.TabIndex = 3;
            this.btnPayout.Text = "Pago";
            this.btnPayout.UseVisualStyleBackColor = true;
            this.btnPayout.Click += new System.EventHandler(this.btnPayout_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblRelojPrincipal);
            this.groupBox4.Location = new System.Drawing.Point(463, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 129);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reloj";
            // 
            // lblRelojPrincipal
            // 
            this.lblRelojPrincipal.Location = new System.Drawing.Point(10, 31);
            this.lblRelojPrincipal.Name = "lblRelojPrincipal";
            this.lblRelojPrincipal.Size = new System.Drawing.Size(242, 95);
            this.lblRelojPrincipal.TabIndex = 0;
            this.lblRelojPrincipal.Text = "00/00/0000\r\n00:00:00";
            this.lblRelojPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrReloj
            // 
            this.tmrReloj.Interval = 1000;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // printTicketLavado
            // 
            this.printTicketLavado.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printTicketLavado_PrintPage);
            // 
            // printTicketRecibo
            // 
            this.printTicketRecibo.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printTicketRecibo_PrintPage);
            // 
            // cmsCobrarActivo
            // 
            this.cmsCobrarActivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cobrarToolStripMenuItem});
            this.cmsCobrarActivo.Name = "cmsCobrarActivo";
            this.cmsCobrarActivo.Size = new System.Drawing.Size(111, 26);
            // 
            // cobrarToolStripMenuItem
            // 
            this.cobrarToolStripMenuItem.Name = "cobrarToolStripMenuItem";
            this.cobrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cobrarToolStripMenuItem.Text = "Cobrar";
            this.cobrarToolStripMenuItem.Click += new System.EventHandler(this.cobrarToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 601);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Principal";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.cmsCobrarActivo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbActivos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrintTicket;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbVendidos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.Button btnPayout;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblRelojPrincipal;
        private System.Windows.Forms.Timer tmrReloj;
        private System.Drawing.Printing.PrintDocument printTicketLavado;
        private System.Windows.Forms.Label lblBarcode;
        private System.Drawing.Printing.PrintDocument printTicketRecibo;
        private System.Windows.Forms.ContextMenuStrip cmsCobrarActivo;
        private System.Windows.Forms.ToolStripMenuItem cobrarToolStripMenuItem;
    }
}

