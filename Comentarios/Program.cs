using System;

namespace Comentarios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Los comentarios que llevan la palabra TODO (para hacer por su siglas en inglés)
             * sirven para crear listas de tareas, estas listas son muy útiles pues nos 
             * ayudan a recordar las tareas que dejamos pendientes en nuestro programas
             * para ver estas tareas pendientes debemos ir al menu Ver > Lista de tareas
             * acontinuacion se abrirá una ventana que recopila todos los comentarios TODO,
             * a veces puede tener un pequeño desaciertos pues si de casualidad en uno de
             * nuestros comentarios si querer iniciamos alguna de sus lineas con la palabra
             * todo en minusculas visual la listara como si fuera tarea pendiente.
             */
            Console.WriteLine("Hello World!");
        }

        void MiMetodo()
        {
            //TODO: debo terminar de realizar este metodo
        }
    }
}
