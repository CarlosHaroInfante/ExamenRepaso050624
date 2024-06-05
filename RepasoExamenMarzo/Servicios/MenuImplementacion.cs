using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamenMarzo.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int menu() {

            Console.WriteLine("Menú de la aplicación");
            Console.WriteLine("---------------------");
            Console.WriteLine("[0] - Cerrar Menú");
            Console.WriteLine("[1] - Menú empleado");
            Console.WriteLine("[2] - Menú gerencia");
            Console.WriteLine("---------------------");

            int op = Convert.ToInt32(Console.ReadLine());

            return op;

        }


        public int menuE()
        {

            Console.WriteLine("Menú de empleados");
            Console.WriteLine("---------------------");
            Console.WriteLine("[0] - Volver");
            Console.WriteLine("[1] - Cálculo total de ventas diario");
            Console.WriteLine("[2] - Añadir venta");
            Console.WriteLine("---------------------");

            int op = Convert.ToInt32(Console.ReadLine());

            return op;
        }

        public int menuG()
        {

            Console.WriteLine("Menú de gerentes");
            Console.WriteLine("---------------------");
            Console.WriteLine("[0] - Volver");
            Console.WriteLine("[1] - Escribir en un fichero todas las ventas del día");
            Console.WriteLine("[2] - Crear un nuevo pedido para proveedores");
            Console.WriteLine("---------------------");

            int op = Convert.ToInt32(Console.ReadLine());

            return op;
        }

    }
}
