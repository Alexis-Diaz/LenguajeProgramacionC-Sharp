using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //PARAMS
            Console.WriteLine("Ejemplo de parámetros indefindos pasados a un método");
            Matematica parametros = new Matematica();
            Console.WriteLine(parametros.Sumar(1, 2.4, 5.6, 3, 4, 7));

            //METODOS DE EXTENSION
            Console.WriteLine("Ejemplo de uso métodos de extensión");
            Clase ME = new Clase();
            ME.MiMetodo();

            MetodosDeExtension ME2 = new MetodosDeExtension();
            ME2.UsarExtension();
            Console.Read();

        }
    }
}
