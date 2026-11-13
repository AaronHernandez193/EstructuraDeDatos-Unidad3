using System;


namespace _5.Sistemas_de_historial_de_navegacion_web
{
    internal class Program
    {
        static Pila atras=new Pila();
        static Pila adelante =new Pila();
        static string actual = "Inicio";
        static void Main()
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("===== Navegador =====");
                Console.WriteLine($"Pagina actual: {actual}");
                Console.WriteLine("1. Visitar Pagina");
                Console.WriteLine("2. Atras");
                Console.WriteLine("3. Adelante");
                Console.WriteLine("0. Salir");
                Console.Write("Opcionn: ");

                opcion = int.Parse( Console.ReadLine() );

                switch( opcion)
                {
                    case 1:
                        atras.Push(actual);
                        Console.Write("Nueva pagina: ");
                        actual = Console.ReadLine();
                        
                        break;
                    case 2:
                        string anterior = atras.Pop();
                        if (anterior != null)
                        {
                            adelante.Push(actual);
                            actual =anterior;
                        }
                        break;

                    case 3:
                        string siguiente = adelante.Pop();
                        if(siguiente != null)
                        {
                            atras.Push(actual);
                            actual =siguiente;
                        }
                        break;
                }
            }while (opcion != 0);
        }
    }
}
