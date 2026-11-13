using System;

namespace Proyecto2_Restaurante
{
    internal class Program
    {
        static Cola espera = new Cola();

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("Restaurante");
                Console.WriteLine("1. Agregar cliente");
                Console.WriteLine("2. Asignar cliente");
                Console.WriteLine("3. Mostrar espera");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese una opción: ");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Agregar();
                        break;
                    case 2:
                        AsignarMesa();
                        break;
                    case 3:
                        espera.Mostrar();
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }


            } while (opcion != 4);

        }
        static void Agregar()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Número de personas: ");
            int personas = int.Parse(Console.ReadLine());

            espera.Encolar(new Cliente(nombre, personas));

            Console.WriteLine("Cliente agregado a la espera.");
            Console.ReadKey();
        }
        static void AsignarMesa()
        {
            Cliente cliente = espera.Desencola();
            if (cliente != null)
            {
                Console.WriteLine($"Cliente {cliente.Nombre} asignado a la mesa.");
            }
            else
            {
                Console.WriteLine("No hay clientes en espera.");
            }
            Console.ReadKey();
        }
    }
}