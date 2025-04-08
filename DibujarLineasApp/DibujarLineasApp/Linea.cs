using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarLineasApp
{
    public class Linea
    {
        public int XInicial { get; set; }
        public int YInicial { get; set; }
        public int XFinal { get; set; }
        public int YFinal { get; set; }
        public static int CantidadLineas { get; private set; }

        public Linea(int xi, int yi, int xf, int yf)
        {
            XInicial = xi;
            YInicial = yi;
            XFinal = xf;
            YFinal = yf;
            CantidadLineas++;
        }

        public void Dibujar(Graphics g)
        {
            using (Pen lapiz = new Pen(Color.Blue, 2))
            {
                g.DrawLine(lapiz, XInicial, YInicial, XFinal, YFinal);
            }
        }
    }
}
