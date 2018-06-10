namespace BoletosAutolavado.Aplication
{
    partial class Venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTicketCode = new System.Windows.Forms.TextBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTicketCode
            // 
            this.txtTicketCode.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketCode.Location = new System.Drawing.Point(12, 12);
            this.txtTicketCode.Multiline = true;
            this.txtTicketCode.Name = "txtTicketCode";
            this.txtTicketCode.PasswordChar = '♦';
            this.txtTicketCode.Size = new System.Drawing.Size(362, 78);
            this.txtTicketCode.TabIndex = 0;
            this.txtTicketCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTicketCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTicketCode_KeyDown);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Location = new System.Drawing.Point(12, 96);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(226, 52);
            this.btnCobrar.TabIndex = 1;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(244, 96);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 52);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 162);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.txtTicketCode);
            this.MaximumSize = new System.Drawing.Size(407, 201);
            this.MinimumSize = new System.Drawing.Size(407, 201);
            this.Name = "Venta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lea el ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTicketCode;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}