using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DibujarLineasApp
{
    public partial class Form1: Form
    {
        private List<Linea> lineas = new List<Linea>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtXInicial.Text, out int xi) ||
                    !int.TryParse(txtYInicial.Text, out int yi) ||
                    !int.TryParse(txtXFinal.Text, out int xf) ||
                    !int.TryParse(txtYFinal.Text, out int yf))
            {
                MessageBox.Show("Por favor, ingrese coordenadas válidas (números enteros).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Linea linea = new Linea(xi, yi, xf, yf);
            lineas.Add(linea);

            lblCantidad.Text = $"Líneas dibujadas: {Linea.CantidadLineas}";

            panelDibujo.Invalidate();  
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (var linea in lineas)
            {
                linea.Dibujar(e.Graphics);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            foreach (var linea in lineas)
            {
                linea.Dibujar(e.Graphics);
            }
        }
    }
}
