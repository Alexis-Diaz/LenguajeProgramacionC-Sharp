using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsII
{
    class LinkedListEjemplo
    {
       
        public static void MiMetodo()
        {
            Console.WriteLine("-----------------CLASE LINKEDLISTEJEMPLO--------------------------");


            // CREACION DE UNA LISTA ENLAZADA
            string[] words ={ "el", "zorro", "saltó", "sobre", "el", "perro" };
            //le pasamos al constructor el array words para crear nodos
            LinkedList<string> sentence = new LinkedList<string>(words);



            //Con el metodo Contains verificamos si existe el nodo 'saltó', devuel true si lo encuentra.
            Console.WriteLine("sentence.Contains(\"saltó\") = {0}",sentence.Contains("saltó"));
            Display(sentence, "Valores de la linkedList:");



            //Agregue la palabra "ahora" al comienzo de la lista vinculada.
            sentence.AddFirst("ahora");
            Display(sentence, "Prueba 1: agregue 'ahora' al principio de la lista:");



            //Mueva el primer nodo para que sea el último nodo.
            //El metodo First de la clase LinkedList selecciona el primer nodo, en este caso "ahora",
            //Nota: si se desea seleccionar el valor solo basta con colocar .Value despues
            //de First.
            LinkedListNode<string> mark1 = sentence.First;
            //Se remueve el primer nodo, en este caso "ahora".
            sentence.RemoveFirst();
            //Se agregar el nodo 'ahora' salvado en 'mark1' al final de la lista de nodos.
            sentence.AddLast(mark1);
            Display(sentence, "Prueba 2: se mueve el primer nodo al final:");



            //Se cambia el último nodo 'ahora' por 'ayer'.
            //Se elimina el último nodo 'ahora'
            sentence.RemoveLast();
            //Se agrega al final "ayer"
            sentence.AddLast("ayer");
            Display(sentence, "Prueba 3: se cambia el último nodo por \"ayer\":");



            //Se mueve al último nodo 'ayer' al principio.
            //con Last se obtiene el último nodo.
            mark1 = sentence.Last;
            //se remueve el ultimo nodo 'ayer'.
            sentence.RemoveLast();
            //se agrega al principio el nodo salvado 'ayer'
            sentence.AddFirst(mark1);
            Display(sentence, "Prueba 4: Se mueve el último nodo al principio:");



            //Indique la última aparición de 'el'.
            //Se elimina el primer nodo "ayer"
            sentence.RemoveFirst();
            //FindLast devuelve la última aparicion del nodo 'el'
            LinkedListNode<string> current = sentence.FindLast("el");
            IndicateNode(current, "Prueba 5: Indica la última aparicion del nodo 'el':");



            //Agregue 'viejo' y 'perezoso' después del último nodo 'el' referenciado en
            //la variable current. 
            //AddAfter agregar un nuevo nodo depues del nodo indicado por parametro
            //Recibe dos parametros:
            //Primer parametro es el nodo de referencia. Aquí current es 'el'.
            //Segundo parametro es el nodo a insertar.
            sentence.AddAfter(current, "y haragán");
            sentence.AddAfter(current, "viejo");
            IndicateNode(current, "Prueba 6: Agrega 'y haragán' y 'viejo' después del último 'el':");



            //El método Find devuelve la primera aparición del nodo
            current = sentence.Find("zorro");
            IndicateNode(current, "Prueba 7: Indica el nodo 'zorro'");



            // Agrega 'rapido' y 'cafe' antes de 'zorro':
            sentence.AddBefore(current, "rapido");
            sentence.AddBefore(current, "y marrón");
            IndicateNode(current, "Prueba 8: Agrega 'rapido' y 'y marrón' antes de 'zorro':");



            //Se guarda en variables una referencia del nodo 'zorro', 'y marrón' y 'perro'
            //La funcion IndicateNode indica el nodo 'perro'
            mark1 = current;// se guarda la referencia del nodo zorro
            LinkedListNode<string> mark2 = current.Previous;//'y marrón' is previous of zorro
            current = sentence.Find("perro");//se guarda la referencia del nodo perro
            IndicateNode(current, "Prueba 9: Indica el nodo perro: ");



            // El metodo AddBefore lanza (throws) una excepcion InvalidOperationException
            // si intenta agregar un nodo que ya pertenece a una lista.
            Console.WriteLine("Prueba 10: Lanza una excepción si se intenta agregar el nodo (zorro) que ya está en la lista:");
            try
            {
                //El metodo AddBefore agrega un nodo despues del nodo indicado
                //Recibe dos parametros donde:
                //current = 'perro'. Nodo de referencia
                //mark1 = 'zorro'. Nodo a insertar
                sentence.AddBefore(current, mark1);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Mensaje de excepción: {0}", ex.Message);
            }
            Console.WriteLine();



            // Elimina el nodo al que hace referencia mark1 (zorro) y luego lo agrega
            // antes del nodo al que hace referencia current (perro).
            // Se indica el nodo current (perro).
            sentence.Remove(mark1);
            sentence.AddBefore(current, mark1);
            IndicateNode(current, "Prueba 11: Mueve el nodo mark1 (zorro) antes del nodo current (perro):");



            //Remueve el nodo referenciado por current (perro)
            sentence.Remove(current);
            IndicateNode(current, "Prueba 12:Elimina el nodo actual (perro) e intenta indicarlo:");



            //Agregue el nodo current (perro) después del nodo al que hace referencia mark2 (y marrón).
            sentence.AddAfter(mark2, current);
            IndicateNode(current, "Prueba 13: Agregue el nodo eliminado en la prueba 11 después de un nodo referenciado mark2 (y marrón):");



            // El método Remove busca y elimina el
            // primer nodo que tiene el valor especificado.
            sentence.Remove("viejo");
            Display(sentence, "Prueba 14: Elimina el nodo que tiene el valor 'viejo':");



            // Cuando la lista vinculada se envía a ICollection (Of String),
            // el método Add agrega un nodo al final de la lista.
            //Notar que se manda a imprimir la LinkedList "sentences" y no
            //la Icollection "icoll". Como se muestra la LinkedList muestra
            //'rinocerontes' como uno nodo.
            sentence.RemoveLast();
            ICollection<string> icoll = sentence;
            icoll.Add("rinoceronte");
            Display(sentence, "Prueba 15: Elimina el último nodo, envía a ICollection y agrega 'rinoceronte':");



            // Crea una matriz con el mismo número de
            // elementos de la lista vinculada.
            Console.WriteLine("Prueba 16: Se copia la LinkedList en un array:");
            string[] sArray = new string[sentence.Count];

            //El metodo CopyTo crea una copia de la totalidad de nodos de la LinkedList<T>
            //en una matriz Array unidimensional compatible, comenzando en el índice
            //especificado de la matriz de destino.
            //Recibe dos parametros:
            //param1: el array que contendrá la copia de la  LinkedList
            //param2: el indice desde donde se comenzará a insertar la copia
            sentence.CopyTo(sArray, 0);
            Console.WriteLine("Esta es la copia de la LinkedList en un array normal");

            foreach (string s in sArray)
            {
                Console.WriteLine(s);
            }



            //Suelta todos los nodos.
            sentence.Clear();
            Console.WriteLine();
            Console.WriteLine("Prueba 17: Limpia la LinkedList.\n sentence.Contains(\"saltó\") = {0}", sentence.Contains("saltó"));
            Console.WriteLine();

        }


        //METODOS DE VISUALIZACION
        private static void Display(LinkedList<string> words, string test)
        {
            Console.WriteLine(test);
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }



        
        private static void IndicateNode(LinkedListNode<string> node, string test)
        {
            Console.WriteLine(test);
            //List indica si el nodo pertenece a una lista vinculada. Devuelve la
            //referencia de la lista a la que se encuentra asociada (lista completa)
            //, si no esta vinculada a ninguna lista devuelve null.
            if (node.List == null)
            {
                Console.WriteLine("El nodo '{0}' no se encuentra en ninguna LinkedList.\n", node.Value);
                return;
            }
            else
            {
                Console.WriteLine("El nodo " + node.Value + " se ecuentra en la lista " + node.List);
            }

            //La clase StringBuilder es parecida a la clase String, pero la diferencia
            //radica en que el primero crea objetos mutables y el segundo inmutable lo
            //lo que significa que al aplicar los metodos de la clase string lo que 
            //en realidad hace es hacer copias, mientras que StringBuilder trabaja
            //directamente en el objeto.
            StringBuilder result = new StringBuilder("(" + node.Value + ")");
            LinkedListNode<string> nodeP = node.Previous;

            while (nodeP != null)
            {
                result.Insert(0, nodeP.Value + " ");
                nodeP = nodeP.Previous;
            }

            node = node.Next;
            while (node != null)
            {
                result.Append(" " + node.Value);
                node = node.Next;
            }

            Console.WriteLine(result);
            Console.WriteLine();
        }
    }

    //Este codigo produce las siguientes salidas por consola:
    //
    //sentence.Contains("salta") = True
    //Valores de la linkedList:
    //el zorro salta sobre el perro

    //Prueba 1: agregue 'hoy' al principio de la lista:
    //hoy el zorro salta sobre el perro

    //Prueba 2: se mueve el primer nodo al final:
    //el zorro salta sobre el perro hoy

    //Prueba 3: se cambia el último nodo por "ayer":
    //el zorro salta sobre el perro ayer

    //Prueba 4: Se mueve el último nodo al principio:
    //ayer el zorro salta sobre el perro

    //Prueba 5: Indica la última aparicion del nodo 'el':
    //El nodo el se ecuentra en la lista System.Collections.Generic.LinkedList`1[System.String]
    //el zorro salta sobre(el) perro

    //Prueba 6: Agrega 'peresozo' y 'viejo' después del último 'el':
    //El nodo el se ecuentra en la lista System.Collections.Generic.LinkedList`1[System.String]
    //el zorro salta sobre(el) perezoso viejo perro

    //Prueba 7: Indica el nodo 'zorro'
    //El nodo zorro se ecuentra en la lista System.Collections.Generic.LinkedList`1[System.String]
    //el(zorro) salta sobre el perezoso viejo perro

    //Prueba 8: Agrega 'rapido' y 'cafe' antes de 'zorro':
    //El nodo zorro se ecuentra en la lista System.Collections.Generic.LinkedList`1[System.String]
    //el rapido café(zorro) salta sobre el perezoso viejo perro

    //Prueba 9: Indica el nodo perro:
    //El nodo perro se ecuentra en la lista System.Collections.Generic.LinkedList`1[System.String]
    //el rapido café zorro salta sobre el perezoso viejo(perro)

    //Prueba 10: Lanza una excepción si se intenta agregar el nodo(zorro) que ya está en la lista:
    //Mensaje de excepción: The LinkedList node already belongs to a LinkedList.

    //Prueba 11: Mueve el nodo mark1 (zorro) antes del nodo current (perro):
    //El nodo perro se ecuentra en la lista System.Collections.Generic.LinkedList`1[System.String]
    //el rapido café salta sobre el perezoso viejo zorro (perro)

    //Prueba 12:Elimina el nodo actual (perro) e intenta indicarlo:
    //El nodo 'perro' no se encuentra en ninguna LinkedList.

    //Prueba 13: Agregue el nodo eliminado en la prueba 11 después de un nodo referenciado mark2 (café):
    //El nodo perro se ecuentra en la lista System.Collections.Generic.LinkedList`1[System.String]
    //el rapido café (perro) salta sobre el perezoso viejo zorro

    //Prueba 14: Elimina el nodo que tiene el valor 'viejo':
    //el rapido café perro salta sobre el perezoso zorro

    //Prueba 15: Elimina el último nodo, envía a ICollection y agrega 'rinoceronte':
    //el rapido café perro salta sobre el perezoso rinoceronte

    //Prueba 16: Se copia la LinkedList en un array:
    //Esta es la copia de la LinkedList en un array normal
    //el
    //rapido
    //café
    //perro
    //salta
    //sobre
    //el
    //perezoso
    //rinoceronte

    //Prueba 17: Limpia la LinkedList.
    //sentence.Contains("salta") = False

}

