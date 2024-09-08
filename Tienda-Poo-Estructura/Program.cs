using System;
using Tienda_Poo_Estructura.Entities;
using Tienda_Poo_Estructura.Services;

namespace Tienda_Poo_Estructura
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClienteServices servicio = new ClienteServices();
            Cliente cliente1 = servicio.AgregarDatos();
            Console.Clear();
            servicio.SumaDelProducto();
            servicio.ImprimirDatosCliente(cliente1);
        }
    }
}
