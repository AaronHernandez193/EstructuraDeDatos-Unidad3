
namespace Sistema_Pacientes
{
    internal class Nodo
    {
        public Paciente Datos;
        public Nodo Siguiente;

        public Nodo(Paciente paciente)
        {
            Datos = paciente;
            Siguiente = null;
        }
    }
}
