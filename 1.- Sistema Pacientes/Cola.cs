using System;

namespace Sistema_Pacientes
{
    public class Cola
    {
        private Nodo frente;
        private Nodo final;

        public void Encolar(Paciente paciente)
        {
            Nodo nuevoNodo = new Nodo(paciente);
            if (frente == null)
            {
                frente = nuevoNodo;
                final = nuevoNodo;
            }
            else
            {
                final.Siguiente = nuevoNodo;
                final = nuevoNodo;
            }
        }
        public Paciente Desencolar()
        {
            if (frente == null)
            {
                return null;
            }
            else
            {
                Paciente paciente = frente.Datos;
                frente = frente.Siguiente;
                if (frente == null)
                {
                    final = null;
                }
                return paciente;
            }
        }
        public void Mostrar()
        {
            Nodo actual = frente;
            if (actual == null)
            {
                Console.WriteLine("No hay pacientes en la cola.");
            }
            else
            {
                Console.WriteLine("Pacientes en la cola:");
                while (actual != null)
                {
                    Console.WriteLine(actual.Datos);
                    actual = actual.Siguiente;
                }
            }
        }
    }
}
