using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculosAPP
{
    public class Taxi : Vehiculo
    {
        public string NumeroLicencia { get; set; }

        public Taxi(string matricula, string modelo, int potenciaCV, string numeroLicencia)
            : base(matricula, modelo, potenciaCV)
        {
            NumeroLicencia = numeroLicencia;
        }

        public new void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Número de Licencia: " + NumeroLicencia);
        }
    }
}
