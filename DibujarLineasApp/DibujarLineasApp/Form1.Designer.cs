namespace DibujarLineasApp
{
    partial class Form1
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
            this.txtXInicial = new System.Windows.Forms.TextBox();
            this.txtYInicial = new System.Windows.Forms.TextBox();
            this.txtXFinal = new System.Windows.Forms.TextBox();
            this.txtYFinal = new System.Windows.Forms.TextBox();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtXInicial
            // 
            this.txtXInicial.Location = new System.Drawing.Point(89, 45);
            this.txtXInicial.Name = "txtXInicial";
            this.txtXInicial.Size = new System.Drawing.Size(100, 22);
            this.txtXInicial.TabIndex = 0;
            // 
            // txtYInicial
            // 
            this.txtYInicial.Location = new System.Drawing.Point(322, 45);
            this.txtYInicial.Name = "txtYInicial";
            this.txtYInicial.Size = new System.Drawing.Size(100, 22);
            this.txtYInicial.TabIndex = 1;
            // 
            // txtXFinal
            // 
            this.txtXFinal.Location = new System.Drawing.Point(89, 98);
            this.txtXFinal.Name = "txtXFinal";
            this.txtXFinal.Size = new System.Drawing.Size(100, 22);
            this.txtXFinal.TabIndex = 2;
            // 
            // txtYFinal
            // 
            this.txtYFinal.Location = new System.Drawing.Point(322, 98);
            this.txtYFinal.Name = "txtYFinal";
            this.txtYFinal.Size = new System.Drawing.Size(100, 22);
            this.txtYFinal.TabIndex = 3;
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(205, 139);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(101, 23);
            this.btnDibujar.TabIndex = 4;
            this.btnDibujar.Text = "Dibujar línea\n";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(269, 165);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(123, 16);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Líneas dibujadas: 0\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelDibujo);
            this.groupBox1.Controls.Add(this.txtXInicial);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.txtYInicial);
            this.groupBox1.Controls.Add(this.btnDibujar);
            this.groupBox1.Controls.Add(this.txtYFinal);
            this.groupBox1.Controls.Add(this.txtXFinal);
            this.groupBox1.Location = new System.Drawing.Point(174, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 438);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PALETA DE DIBUJO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panelDibujo
            // 
            this.panelDibujo.Location = new System.Drawing.Point(23, 205);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(491, 217);
            this.panelDibujo.TabIndex = 6;
            this.panelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujo_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtXInicial;
        private System.Windows.Forms.TextBox txtYInicial;
        private System.Windows.Forms.TextBox txtXFinal;
        private System.Windows.Forms.TextBox txtYFinal;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelDibujo;
    }
}

