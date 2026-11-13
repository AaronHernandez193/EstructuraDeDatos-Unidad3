using System.Collections.Generic;

namespace _5.Sistemas_de_historial_de_navegacion_web
{
    public class Pila
    {
        private Nodo tope;
        private class Nodo
        {
            public string Pagina;
            public Nodo Siguiente;

            public Nodo(string pagina)
            {
                Pagina = pagina;
                
            }
            
        }
        public void Push(string pagina)
        {
            Nodo nuevo = new Nodo(pagina);
            nuevo.Siguiente = tope;
            tope = nuevo;
        }
        public string Pop()
        {
            if (tope == null)
                return null;

            string pagina = tope.Pagina;
            tope = tope.Siguiente;

            return pagina;
        }
    }
}
