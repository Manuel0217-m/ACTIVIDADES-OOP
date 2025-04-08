using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadApp
{
    class Ordinario : Profesor
    {
        public int AniosServicio { get; set; }

        public Ordinario(string nombre, string apellido, string cedula, string dedicacion, int anios)
            : base(nombre, apellido, cedula, dedicacion)
        {
            AniosServicio = anios;
        }

        public override string Detalle()
        {
            return $"{base.ToString()} - Ordinario con {AniosServicio} años de servicio";
        }
    }
}
