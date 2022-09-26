using System;
using System.Collections.Generic;

namespace DelegadosIII
{
    class Program
    {
        //Las expresiones lambda son funciones anonimas
        //o no tienen un nombre. Se utilizan para realizar
        //tareas sencillas y se evita escribir metodos completos.

        //Se utilizan mucho cuando se crean delegados sencillos
        //y al utilizar LinQ. Segun parece la expresion lambda
        //siempre retorna algo.


        static void Main(string[] args)
        {
           
            //Uso del delgado con una expresion lanbda
            //Explicacion: En vez de hacer referencia a una funcion
            //el delegado toma en el constructor una funcion anonima.
            //La sintaxi de la expresion lambda es la siguiente:
            //
            //(parametros que recibe) (expresion lambda) (cuerpo de la función)
            //        num                    =>               num * num;
            //
            //.

            //con un parametro
            operacionesMatematicas op = new operacionesMatematicas(num => num*num);
            Console.WriteLine(op(8));


            //con dos parametros
            operacionesMatematicas2 op2 = new operacionesMatematicas2((num1, num2) => num1 + num2);
            Console.WriteLine(op2(8,3));





            //EJEMPLO 2
            Console.WriteLine();
            Programa.MiMetodo();
        }

        public delegate int operacionesMatematicas(int numero);
        public delegate int operacionesMatematicas2(int numero1, int numero2);

    }
}
