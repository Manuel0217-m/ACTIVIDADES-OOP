using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculosAPP
{
    class Program
    {
        static void Main()
        {
            
            Taxi miTaxi = new Taxi("ABC123", "Toyota Prius", 100, "TX-9876");
            Autobus miAutobus = new Autobus("XYZ789", "Mercedes Sprinter", 150, 30);

            
            Console.WriteLine("Información del Taxi:");
            miTaxi.MostrarInformacion();
            Console.WriteLine();

            Console.WriteLine("Información del Autobús:");
            miAutobus.MostrarInformacion();
            Console.WriteLine();

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
