using System;
using System.Collections.Generic;

namespace CollectionsII
{
    class Program
    {
        static void Main(string[] args)
        {

            //Las LinkedList y las List se diferencian porque las primeras
            //son más eficientes al momento de manejar datos. Las List ordenan
            //los datos de tal manera que cada elemento está acontinuacion del
            //otro, al eliminar o agregar uno todos los
            //elementos deben reordenarse afectando la rapidez con que maneja
            //los datos. Las LinkedList por el contrario es una coleccion de
            //datos referenciados entre si, es decir, no necesitan estar uno
            //despues del otro, al eliminar o agregar un elemento solamente
            //se actualizan las referencias del elemento anterior y siguiente
            //entre los cuales se encuentra el nuevo elemento.

            //Las LinkedList en realidad son una coleccion de nodos,
            //Los nodos son objetos de la clase LinkedListNode. Al crear
            //un objeto nodo individual este carece de enlaces hacia otros nodos
            //esto cambia hasta que el nodo se agrega a una LinkedList. Los
            //nodos pueden crearse directamente desde la clase LinkedListNode y
            //y luego ser asignados a un objeto LinkedList o bien directamente
            //desde la instancia de una LinkedList.

            LinkedListEjemplo.MiMetodo();



            Console.WriteLine("-----------------CLASE PROGRAM--------------------------");

            LinkedList<int> ListaNumeros = new LinkedList<int>();

            foreach(int item in new int[] { 2, 3, 5, 5654, 675, 343, 254, 23, 45 })
            {
                //El metodo AddFirst coloca el elemento en la primera posicion
                //de tal manera que el ultimo llega a hacer primero.
                ListaNumeros.AddFirst(item);//output 45, 23, 254, 343, 675, 5654, 5, 3, 2
            }

            foreach (int item in ListaNumeros)
            {
                Console.WriteLine(item);      
            }

            Console.WriteLine("---------------------------------");

            LinkedList<int> ListaNumeros2 = new LinkedList<int>();

            foreach (int item in new int[] { 2, 3, 5, 5654, 675, 343, 254, 23, 45 })
            {
                //El metodo AddLast coloca el elemento en la última posicion
                //de tal manera que el primero siempre es primero.
                ListaNumeros2.AddLast(item);//output 2, 3, 5, 5654, 675, 343, 254, 23, 45
            }

            foreach (int item in ListaNumeros2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------otra forma de leer----------------------");


            //Este for lo que hace es primero tomar la referencia del primero nodo de la lista
            //, luego verifica si es diferente de null, si es diferente pasa al siguiente nodo.
            //Despues de recorrer toda la lista de nodos, la variable nodo es igual a null es
            //en este punto cual el for termina.
            for (LinkedListNode<int> nodo = ListaNumeros2.First;nodo!= null; nodo = nodo.Next)
            {
                int numero = nodo.Value;
                Console.WriteLine(numero);
            }

        }
    }
}
