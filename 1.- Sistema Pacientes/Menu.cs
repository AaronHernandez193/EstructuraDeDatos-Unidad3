using System;

namespace Sistema_Pacientes
{
    internal class Program
    {
        static Cola pacientes = new Cola();

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("===== CLINICA =====");
                Console.WriteLine("1. Registrar Paciente.");
                Console.WriteLine("2. Atender Paciente.");
                Console.WriteLine("3. Mostrar Paciente");
                Console.WriteLine("0. Salir");
                Console.Write("Opcion: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Registrar();
                        break;

                    case 2:
                        Atender();
                        break;

                    case 3:
                        pacientes.Mostrar();
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    
                }
            }while (opcion != 0);
        }
        static void Registrar()
        {
            Console.Clear();
            Console.WriteLine("===== REGISTRAR PACIENTE =====");
            Console.Write("Expediente: ");
            int expediente = int.Parse(Console.ReadLine());
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Prioridad: ");
            int prioridad = int.Parse(Console.ReadLine());
            Paciente paciente = new Paciente(expediente, nombre, edad, prioridad);
            pacientes.Encolar(paciente);
            Console.WriteLine("\nPaciente registrado correctamente.");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        static void Atender()
        {
            Console.Clear();
            Console.WriteLine("===== ATENDER PACIENTE =====");
            Paciente paciente = pacientes.Desencolar();
            if (paciente != null)
            {
                Console.WriteLine($"Atendiendo al paciente: {paciente.Nombre}");
            }
            else
            {
                Console.WriteLine("No hay pacientes en la cola.");
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
