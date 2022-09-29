using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo de parámetros indefindos pasados a un método");
            Matematica parametros = new Matematica();
            Console.WriteLine(parametros.Sumar(1, 2.4, 5.6, 3, 4, 7));
            Console.Read();

        }
    }
}
