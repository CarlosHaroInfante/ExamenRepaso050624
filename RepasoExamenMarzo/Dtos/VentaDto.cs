using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamenMarzo.Dtos
{
    internal class VentaDto
    {
        long idVenta;

        double precio = 99.99;

        DateTime fechaCompra = DateTime.Now;

        public long IdVenta { get => idVenta; set => idVenta = value; }
        public double Precio { get => precio; set => precio = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }

        public string ToString()
        {
            string mensaje = "........... \n" + 
               "Venta número " + this.idVenta + "\n" +
               "Euros: " + this.precio + "\n" +
               "Instante compra: " + fechaCompra + "\n";

            return mensaje;
        }
    }
}
