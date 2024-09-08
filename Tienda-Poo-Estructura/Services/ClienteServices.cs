using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_Poo_Estructura.Entities;

namespace Tienda_Poo_Estructura.Services
{
    public class ClienteServices
    {
        //Funcion Para Agregar Los Datos Personales Del Cliente
        public Cliente AgregarDatos()
        {
            try
            {
                Cliente datos = new Cliente();
                // - - -
                Console.Write("Ingresar Nombre: ");
                datos.Nombre = Console.ReadLine();

                Console.Write("Ingresar Telefono: ");
                datos.Telefono = Console.ReadLine();

                Console.Write("Ingresar Correo: ");
                datos.Correo = Console.ReadLine();

                return datos;
            }
            catch (Exception ex)
            {
                throw new Exception("OCURRIO UN ERROR: " + ex.Message);
            }
        }

        //Funcion Para Pedir y Sumar Los Numeros De Productos
        public int SumaDelProducto()
        {
            try
            {
                int PnTotal = 0;
                Console.WriteLine("Ingrese 5 Numeros De Articulos: ");
                //- - -
                for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Articulo: ", i);
                    int numero = Convert.ToInt32(Console.ReadLine());
                    PnTotal += numero;
                }
                //- - -
                Console.Clear();
                Console.Write("Suma Total:");
                Console.WriteLine(PnTotal);
                //- - -
                if (PnTotal >= 10000)
                {
                    Console.WriteLine("¡Tienes la opción de elegir entre 3 o 6 meses sin intereses!");
                    Console.WriteLine("¿Cuántos meses sin intereses deseas? (3/6):");
                    int MesesSinIntereses = Convert.ToInt32(Console.ReadLine());
                    double descuento;
                    if (MesesSinIntereses == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Total Sin Descuento: " + PnTotal);
                        Console.WriteLine("¡Elegiste 3 meses sin intereses!");
                        Console.WriteLine();
                        PnTotal = PnTotal / 3;
                        Console.WriteLine("Total Con Descuento: " + PnTotal);
                    }
                    else if (MesesSinIntereses == 6)
                    {
                        Console.Clear();
                        Console.WriteLine("Total Sin Descuento: " + PnTotal);
                        Console.WriteLine("¡Elegiste 6 meses sin intereses!");
                        Console.WriteLine();
                        PnTotal = PnTotal / 6;
                        Console.WriteLine("Total Con Descuento: " + PnTotal);
                    }
                    else
                    {
                        throw new Exception("Opción inválida. Debes elegir entre 3 o 6 meses sin intereses.");
                    }
                }
                else if (PnTotal >= 8000)
                {
                    Console.Clear();
                    Console.WriteLine("Total Sin Descuento: " + PnTotal);
                    Console.WriteLine("¡Tienes 3 meses sin intereses!");
                    Console.WriteLine();
                    PnTotal = PnTotal / 3;
                    Console.WriteLine("Total Con Descuento: " + PnTotal);
                }
                else if (PnTotal >= 5000)
                {
                    Console.Clear();
                    Console.WriteLine("Total Sin Descuento: "+PnTotal);
                    Console.WriteLine("¡Tienes un descuento del 10%!");
                    Console.WriteLine();
                    double descuento = PnTotal * 0.1;
                    PnTotal -= (int)descuento;
                    Console.WriteLine("Total Con Descuento: " + PnTotal);
                }
                //- - -
                return PnTotal;
            }
            catch(Exception ex)
            {
                throw new Exception("OCURRIO UN ERROR: " + ex.Message);
            }
        }

        //Funcion Para Imprimir Los Datos Del Cliente
        public void ImprimirDatosCliente(Cliente request)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Datos Del Cliente:");
                Console.WriteLine("Nombre: "+request.Nombre);
                Console.WriteLine("Telefono: "+request.Telefono);
                Console.WriteLine("Correo: "+request.Correo);
            }
            catch(Exception ex)
            {
                throw new Exception("Sucedio un Error " + ex.Message);
            }
        }
    }
}
