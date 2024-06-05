using RepasoExamenMarzo.Dtos;
using RepasoExamenMarzo.Servicios;

namespace RepasoExamenMarzo.Controladores
{

    class Program
    {


        public static void Main(string[] args)
        {

            try
            {
                List<ProductosDto> productos = new List<ProductosDto>();
                List<VentaDto> venta = new List<VentaDto>();
                MenuInterfaz menu = new MenuImplementacion();
                OperativaInterfaz operativa = new OperativaImplementacion();

                bool cerrarMenu = false;

                while(!cerrarMenu)
                {

                    int opcion = menu.menu();

                    switch(opcion)
                    {
                        case 0:
                            Console.WriteLine("Se cierra el menú");
                            cerrarMenu = true;
                            break;
                        case 1:
                            int opE = menu.menuE();
                            switch (opE)
                            {
                                case 0:
                                    Console.WriteLine("Volver");
                                    break;
                                case 1:
                                    operativa.calculoVentasDiario(venta);
                                    break; 
                                case 2:
                                    operativa.aniadirVenta(venta);
                                    break;
                            }
                            break; 
                        case 2:
                            int opG = menu.menuG();
                            switch (opG)
                            {
                                case 0:
                                    Console.WriteLine("Volver");
                                    break;
                                case 1:
                                    operativa.mostrarVentas(venta);
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        default: 
                            Console.WriteLine("Opción no válida, intentelo de nuevo.");
                            break;
                            
                    }

                }




            }
            catch(Exception ex) {
                Console.WriteLine("Se ha producido un error en el main de la aplicación " + ex.Message);
            
            }


        }

    }

}
