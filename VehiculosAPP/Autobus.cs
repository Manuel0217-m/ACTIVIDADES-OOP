using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculosAPP
{
   public class Autobus : Vehiculo
    {
        public int NumeroPlazas { get; set; }

        public Autobus(string matricula, string modelo, int potenciaCV, int numeroPlazas)
            : base(matricula, modelo, potenciaCV)
        {
            NumeroPlazas = numeroPlazas;
        }

        public new void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Número de Plazas: " + NumeroPlazas);
        }
    }

}
