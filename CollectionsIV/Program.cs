using System;
using System.Collections.Generic;

namespace CollectionsIV
{
    class Program
    {
        //La clase Stack es lo contrario a las Queue
        //Por ejemplo como una pila de platos, el ultimo
        //en entrar es el primero en salir.

        //Se resume con el siguiente acrónimo
        //L: last  = ultimo
        //I: in    = en entrar
        //F: first - primero
        //O: out   = en salir

        static void Main(string[] args)
        {
            //La clase Stack se instancia para crear un objeto
            //como son clases genericas se le agrega un tipo
            //aqui se usa int aunque puede ser una clase.
            Stack<int> numeros = new Stack<int>();

            //AGREGANDO ELEMENTOS
            foreach (int numero in new int[5] { 2, 3, 4, 5, 6 })
            {
                //El metodo Push agregar elementos en cola
                numeros.Push(numero);
            }

            //recorriendo los elementos
            Console.WriteLine("recorriendo el Stack");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine();


            //ELIMINANDO ELEMENTOS
            Console.WriteLine("eliminando elementos del Stack");
            //El metodo Pop elimina el ultimo elemento en entrar
            //el metodo no admite parametros, ni alguna forma de 
            //de indicar que elimine otro elemento porque todo lo
            //hace secuencial.
            numeros.Pop();
            //recorriendo los elementos

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }



            Console.WriteLine();
            Console.WriteLine("DICCIONARIOS");

            //DICCIONARIO
            Diccionario.MiMetodo();
        }
    }
}
