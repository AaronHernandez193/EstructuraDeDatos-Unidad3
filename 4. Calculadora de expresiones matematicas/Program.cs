using System;


namespace _4.Calculadora_de_expresiones_matematicas
{
    internal class Program
    {
        static int Prioridad(char operador)
        {
            if (operador == '+' || operador == '-')
                return 1;
            else if (operador == '*' || operador == '/')
                return 2;
            else if (operador == '^')
                return 3;
            else
                return 0;
        }
    }
}
