using RepasoExamenMarzo.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamenMarzo.Servicios
{
    internal interface OperativaInterfaz
    {
        public void aniadirVenta(List<VentaDto> listaVenta);

        public void calculoVentasDiario(List<VentaDto> listaVenta);

        public void mostrarVentas(List<VentaDto> listaVenta);
    }
}
