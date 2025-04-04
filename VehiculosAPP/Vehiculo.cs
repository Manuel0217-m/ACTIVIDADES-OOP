using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculosAPP
{
    public class Vehiculo
    {
        public string Matricula { get; set; }
        public string Modelo { get; set; }
        public int PotenciaCV { get; set; }

        public Vehiculo(string matricula, string modelo, int potenciaCV)
        {
            Matricula = matricula;
            Modelo = modelo;
            PotenciaCV = potenciaCV;
        }

        public void MostrarInformacion()
        {
             Console.WriteLine("Matrícula: " + Matricula + ", Modelo: " + Modelo + ", Potencia: " + PotenciaCV + " CV");
        }
    }
}
