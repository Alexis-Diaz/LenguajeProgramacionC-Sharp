using System;
using System.Collections.Generic;

namespace DelegadosII
{
    class Program
    {
       //DELEGADOS PREDICADOS
       //EJEMPLO 1

        //Son delegados normales pero la diferencia
        //es que lo que devuelve es true o false.

        //Son muy utiles al usar listas, pues tiene metodos
        //que piden de parametros predicate

        static void Main(string[] args)
        {
            //Creamos una lista de numeros
            List<int> listaNumeros = new List<int>();
            //El metodo AddRange permite añadir al final de la lista una serie de elementos.
            listaNumeros.AddRange(new int[] 
            { 
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
                31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
                41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                51, 52, 53, 54, 55, 56, 57, 58, 59, 60,
                61, 62, 63, 64, 65, 66, 67, 68, 69, 70,
                71, 72, 73, 74, 75, 76, 77, 78, 79, 80,
                81, 82, 83, 84, 85, 86, 87, 88, 89, 90,
                91, 92, 93, 94, 95, 96, 97, 98, 99, 100,
            });


            //Para crear un delegado predicado se instancia el delegado Predicate
            //que pertence a la libreria de System. Luego por su constructor le 
            //pasamos la referencia hacia el metodo.

            //¿Cómo funciona todo esto?
            //Primero el método FindAll itera sobre todos los elementos
            //de la lista, cada elemento lo pasa al predicado delegado
            //como si de parametros se tratara, (es por eso que el predicado
            //debe ser de tipo int). Luego el predicado
            //lo pasa a la funcion DamePares para que este último por medio
            //de true o false indique si el elemento cumple o no la condición.

            //Finalmente FindAll devuelve una nueva lista con los numeros
            //que marcaron true.
            
            Predicate<int> elDelegadoPred = new Predicate<int>(DamePrimos);
            List<int> numerosPares = listaNumeros.FindAll(elDelegadoPred);

            foreach(int num in numerosPares)
            {
                Console.WriteLine(num);
            }




            //EJEMPLO 2
            Programa.MiMetodo();
        }

        //Esta funcion devuelve true o false 
        //dependiente si el numero es par o no.
        static bool DamePares (int num)
        {
            if (num % 2 == 0) return true;
            else return false;
        }


        //Esta funcion devuelve true si el
        //numero es primo y false en caso
        //contrario.
        static bool DamePrimos(int num)
        {
            //se excluye de una vez el 1 y el
            //numero que se recibe.

            //De entrada decimos que todos son
            //primos, pero en el proceso filtramos.
            //Al encontrar la primera división
            //exacta que no sea 1 y el mismo
            //numero recibido, devolvemos false
            //indicando que el numero no es primo.
            bool res = true;

            if (num == 1) res = false;//1 no es primo

            for (int k=2; k<num; k++)
            {
               
                if (num % k == 0)  res = false; 
            }
            return res;
        }

    }
}
