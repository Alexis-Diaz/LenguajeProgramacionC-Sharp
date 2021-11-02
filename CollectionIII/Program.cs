using System;
using System.Collections.Generic;

namespace CollectionsIII
{
    class Program
    {
        //Las Queue son listas de elementos en forma de colas
        //parecido a una cola de espera para entrar al cine.

        //La forma de operar se resume en el siguiente acrónicmo
        //F: first = primero
        //I: in    = en entrar
        //F: first = primero
        //O: out   = en salir

        //Al agregar elementos se hace de manera secuencial, y de
        //la manera en que entran es la manera en que salen.

        //Se usan cuando en programa se necesita usar procesos 
        //secuenciales, es decir, uno después de otros.

        static void Main(string[] args)
        {
            //La clase Queue se instancia para crear un objeto
            //como son clases genericas se le agrega un tipo
            //aqui se usa int aunque puede ser una clase.
            Queue<int> numeros = new Queue<int>();

            //AGREGANDO ELEMENTOS
            foreach(int numero in new int[5] { 2, 3, 4, 5, 6 })
            {
                //El metodo Enqueue agregar elementos en cola
                numeros.Enqueue(numero);
            }

            //recorriendo los elementos
            Console.WriteLine("recorriendo el Queue");

            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine();


            //ELIMINANDO ELEMENTOS
            Console.WriteLine("eliminando elementos del Queue");
            //El metodo Dequeue elimina el primer elemento en entrar
            //el metodo no admite parametros, ni alguna forma de 
            //de indicar que elimine otro elemento porque todo lo
            //hace secuencial.
            numeros.Dequeue();
            //recorriendo los elementos

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
