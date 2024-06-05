using Microsoft.VisualBasic;
using RepasoExamenMarzo.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamenMarzo.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void aniadirVenta(List<VentaDto> listaVenta)
        {

            VentaDto ventaNueva = new VentaDto();

            Console.WriteLine("Importe de la venta realizada");
            ventaNueva.Precio = Convert.ToDouble(Console.ReadLine());

            ventaNueva.IdVenta = idAutoVenta(listaVenta);

            listaVenta.Add(ventaNueva);

            foreach(VentaDto productos in listaVenta)
            {
                Console.WriteLine(productos.IdVenta.ToString() + " " + productos.Precio.ToString() + " " + productos.FechaCompra);
            }


        }

        public void calculoVentasDiario(List<VentaDto> listaVenta)
        {
            
            Console.WriteLine("Fecha del dia [dd-MM-yyyy]");
            string fechaString = Console.ReadLine();
            double totalVentasHoy = 0;
            List<DateTime> fechasVenta = new List<DateTime>();
            foreach(VentaDto venta in listaVenta)
            {
               
                string fechaFormateada = venta.FechaCompra.ToString("dd-MM-yyyy");

                if(fechaFormateada.Equals(fechaString))
                {
                    fechasVenta.Add(venta.FechaCompra);
                    totalVentasHoy = totalVentasHoy + venta.Precio;
                }

                Console.WriteLine("Total Ventas: " +  totalVentasHoy);

                fechasVenta.Sort();
                TimeSpan diferenciaFecha = fechasVenta[fechasVenta.Count - 1] - fechasVenta[0];

                Console.WriteLine("Tiempo transcurrido: " + diferenciaFecha.Hours + " horas " + diferenciaFecha.Minutes +
                    " minutos " + diferenciaFecha.Seconds + " segundos ");


            }
            

        }

        public void mostrarVentas(List<VentaDto> listaVenta)
        {

            Console.WriteLine("fecha del dia que quieres ver las ventas [dd-MM-yyyy]");
            string fechaString = Console.ReadLine();

            DateTime fechaHoy = DateTime.Now;

            string fecha = fechaHoy.ToString("ddMMyyyy");

            foreach(VentaDto venta in listaVenta)
            {
                string fechaFormateada = venta.FechaCompra.ToString("dd-MM-yyyy");
                if (fechaFormateada.Equals(fechaString))
                {

                    string ruta = "C:\\Users\\Carlos\\Desktop\\Programación\\RepasoExamenMarzo\\" + fecha + ".txt";

                    using(StreamWriter escribe = new StreamWriter(ruta, true))
                    { 
                    
                        escribe.WriteLine(venta.ToString());
                        escribe.Close();

                    }

                }
            }

        }


        private long idAuto(List<ProductosDto> listaProductos)
        {

            long idN;

            int tamanioLista = listaProductos.Count;

            if( tamanioLista > 0)
            {
                idN = listaProductos[tamanioLista - 1].Id + 1;
            }
            else
            {
                idN = 1;
            }

            return idN;

        }

        private long idAutoVenta(List<VentaDto> listaVenta)
        {

            long idN;

            int tamanioLista = listaVenta.Count;

            if (tamanioLista > 0)
            {
                idN =   listaVenta[tamanioLista - 1].IdVenta + 1;
            }
            else
            {
                idN = 1;
            }

            return idN;

        }
    }
}
