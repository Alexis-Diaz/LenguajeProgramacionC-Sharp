using System;

namespace LanzamientoDeExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Lanzamiento de excepciones. Al programar se pueden lanzar 
            excepciones que son propias de .net. Por ejemplo si creamos 
            un metodo que recibe parametros y uno de ellos es erróneo
            podemos lanzar una excepción. De esta manera nos obligamos 
            u ubligamos a otro programador a usar try {} catch{} al usar 
            nuestro método para capturar la excepción. El único inconve-
            niente es que debemos investigar cuál excepcion es la más
            apropiada de las contenidas en las librerías de .net
             */
            Console.WriteLine("Introduce el numero de mes (1-12)");

            try
            {
                int mes = int.Parse(Console.ReadLine());
                Console.WriteLine(NombreDelMes(mes));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo un error: {ex.Message}");
            }
           
            Console.WriteLine("mas tareas a ejecutar");
        }

        public static string NombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    throw new ArgumentOutOfRangeException("mes","El valor debe estar entre 1 y 12.");//excepcion que indica que el argumento o valor esta fuera de rango. El primer parametro se usa para indicar el paramentro con error y el otro el mensaje personalizado.
            }
        }
    }
}
