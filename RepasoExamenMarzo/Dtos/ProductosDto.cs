using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamenMarzo.Dtos
{
    internal class ProductosDto
    {
        long id;

        string nombreProducto = "aaaaa";

        int cantidad = 1;

        DateTime fechaDeseadaEntrega = new DateTime(9999, 12, 31);



        public long Id { get => id; set => id = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime FechaDeseadaEntrega { get => fechaDeseadaEntrega; set => fechaDeseadaEntrega = value; }


        public string ToString()
        {
            string mensaje =
                "Producto: " + this.NombreProducto + "\n" +
                "Cantidad de productos: " + this.cantidad + "\n" +
                "Fecha deseada de entrega: " + this.fechaDeseadaEntrega + "\n";

            return mensaje;
        }
        
    }
}
