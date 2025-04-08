using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadApp
{
    abstract class Profesor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Dedicacion { get; set; }

        public Profesor(string nombre, string apellido, string cedula, string dedicacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Dedicacion = dedicacion;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} - {Cedula} - {Dedicacion}";
        }

        public abstract string Detalle();
    }
}
