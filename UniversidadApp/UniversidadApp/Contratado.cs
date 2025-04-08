using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadApp
{
    class Contratado : Profesor
    {
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaFinContrato { get; set; }

        public Contratado(string nombre, string apellido, string cedula, string dedicacion, DateTime ingreso, DateTime fin)
            : base(nombre, apellido, cedula, dedicacion)
        {
            FechaIngreso = ingreso;
            FechaFinContrato = fin;
        }

        public override string Detalle()
        {
            return $"{base.ToString()} - Contratado desde {FechaIngreso.ToShortDateString()} hasta {FechaFinContrato.ToShortDateString()}";
        }
    }
}
