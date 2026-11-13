using Proyecto3_Llamadas;
using System;


namespace _3.Simulador_de_llamadas_telefonicas
{
    internal class Program
    {
        static Pila llamadas = new Pila();

        static
            void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Simulador de llamadas telefónicas");
                Console.WriteLine("1. Agregar llamada");
                Console.WriteLine("2. Atender llamada");
                Console.WriteLine("3. Mostrar llamadas en espera");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Funcion: ");
                        llamadas.Apilar(Console.ReadLine());
                        break;
                    case 2:
                        string llamada = llamadas.Desapilar();
                        Console.WriteLine(llamada == null ?"No existen llamadas.": $"Regresando de {llamada}");
                        break;
                    case 3:
                        Console.Write("Llamadas en espera:\n");
                        llamadas.Mostrar();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
                Console.WriteLine();
            } while (opcion != 4);
        }
    }
}
