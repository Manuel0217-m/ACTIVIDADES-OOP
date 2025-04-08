using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadApp
{
    class Program
    {
        static List<Profesor> profesores = new List<Profesor>();

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Sistema de Gestión de Profesores ===");
                Console.WriteLine("1. Añadir Profesor");
                Console.WriteLine("2. Eliminar Profesor");
                Console.WriteLine("3. Modificar Profesor");
                Console.WriteLine("4. Reporte 1");
                Console.WriteLine("5. Reporte 2");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: IncluirProfesor(); break;
                    case 2: EliminarProfesor(); break;
                    case 3: ModificarProfesor(); break;
                    case 4: ReporteGeneral(); break;
                    case 5: ReporteDetallado(); break;
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 0);
        }

        static void IncluirProfesor()
        {
            Console.Write("Tipo (1. Contratado, 2. Ordinario): ");
            int tipo = int.Parse(Console.ReadLine());

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Cédula: ");
            string cedula = Console.ReadLine();
            Console.Write("Dedicación: ");
            string dedicacion = Console.ReadLine();

            if (tipo == 1)
            {
                Console.Write("Fecha de Ingreso (yyyy-MM-dd): ");
                DateTime ingreso = DateTime.Parse(Console.ReadLine());
                Console.Write("Fecha fin de contrato (yyyy-MM-dd): ");
                DateTime finContrato = DateTime.Parse(Console.ReadLine());

                profesores.Add(new Contratado(nombre, apellido, cedula, dedicacion, ingreso, finContrato));
            }
            else if (tipo == 2)
            {
                Console.Write("Años de servicio: ");
                int anios = int.Parse(Console.ReadLine());

                profesores.Add(new Ordinario(nombre, apellido, cedula, dedicacion, anios));
            }

            Console.WriteLine("Profesor agregado correctamente.");
        }

        static void EliminarProfesor()
        {
            Console.Write("Cédula del profesor a eliminar: ");
            string cedula = Console.ReadLine();

            var profesor = profesores.Find(p => p.Cedula == cedula);
            if (profesor != null)
            {
                profesores.Remove(profesor);
                Console.WriteLine("Profesor eliminado.");
            }
            else
            {
                Console.WriteLine("Profesor no encontrado.");
            }
        }

        static void ModificarProfesor()
        {
            Console.Write("Cédula del profesor a modificar: ");
            string cedula = Console.ReadLine();

            var profesor = profesores.Find(p => p.Cedula == cedula);
            if (profesor != null)
            {
                Console.Write("Nuevo nombre: ");
                profesor.Nombre = Console.ReadLine();
                Console.Write("Nuevo apellido: ");
                profesor.Apellido = Console.ReadLine();
                Console.Write("Nueva dedicación: ");
                profesor.Dedicacion = Console.ReadLine();

                Console.WriteLine("Datos modificados.");
            }
            else
            {
                Console.WriteLine("Profesor no encontrado.");
            }
        }

        static void ReporteGeneral()
        {
            foreach (var p in profesores)
            {
                Console.WriteLine(p);
            }
        }

        static void ReporteDetallado()
        {
            foreach (var p in profesores)
            {
                Console.WriteLine(p.Detalle());
            }
        }
    }

}
