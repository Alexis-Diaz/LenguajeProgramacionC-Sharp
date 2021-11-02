using System;
using System.Collections.Generic;

namespace CollectionsI
{
    class Program
    {
        //Las listas genericas son parecidos a los array, pero a costo
        //de mayor uso de computo nos ofrecen propiedades y metodos muy
        //utiles que un array no puede.
        //Entre ellos tenemos:
        //Agregar
        //Eliminar
        //Ordernar
        //Buscar
        //La ventaja enorme estriba en que lo anterior se puede realizar
        //en tiempo de ejecucion.
        static void Main(string[] args)
        {
            //EJEMPLO 1
            //declaracion de una lista
            List<int> ListaNumeros1 = new List<int>();

            //agregacion de elementos
            ListaNumeros1.Add(5);
            ListaNumeros1.Add(4);
            ListaNumeros1.Add(3);
            
            //recorrido
            for(int i=0; i<3; i++)
            {
                Console.WriteLine(ListaNumeros1[i]);
            }

            Console.WriteLine("-------------------");

            //EJEMPLO 2
            //declaracion de una lista
            List<int> ListaNumeros2 = new List<int>();

            //creacion de un array convencional
            int[] listnumeros = new int[5] { 1, 2, 3, 4, 5 };

            //agregacion de elementos en tiempo de ejecucion
            for(int i=0; i < 5; i++)
            {
                ListaNumeros2.Add(listnumeros[i]);
            }

            //recorrido
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ListaNumeros2[i]);
            }


            //EJEMPLO 3
            List<int> ListaNumeros3 = new List<int>();

            Console.WriteLine("Cuantos elementos quieres introducir");
            int elem = int.Parse(Console.ReadLine());

            Console.WriteLine("elementos ingresados");


            //agregacion de elementos en tiempo de ejecucion
            for (int i = 0; i < elem; i++)
            {
                ListaNumeros3.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("lista creada");
            
            //recorrido
            for (int i = 0; i < elem; i++)
            {
                Console.WriteLine(ListaNumeros3[i]);
            }

            //EJEMPLO 4
            List<int> ListaNumeros4 = new List<int>();

            Console.WriteLine("Introduce elementos para la coleccion (0 para salir)");
            int elems = 1;

            while(elems != 0)
            {
                elems = int.Parse(Console.ReadLine());
                ListaNumeros4.Add(elems);
            }

            //para eliminar se puede usar RemoveAt donde recibe por
            //parametro un indice.
            ListaNumeros4.RemoveAt(ListaNumeros4.Count - 1);
            Console.WriteLine("lista creada");

            //recorrido
            foreach (int elementoss in ListaNumeros4)
            {
                Console.WriteLine(elementoss);
            }
        }
    }
}
