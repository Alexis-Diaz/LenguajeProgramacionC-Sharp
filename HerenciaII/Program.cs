using System;
using System.Collections.Generic;

namespace HerenciaII
{
    //HERENCIA SEGUNDA PARTE

    //Gracias a la herencia podemos simplificar código, ya
    //que podemos en una clase base declarar propiedades y 
    //métodos una sola vez y propagarlos (usarlos) en las
    //clases hijas.

    //Considerar la siguiente clase
    class Animal
    {
        public string Nombre { get; set; }

        //Los métodos virtuales son aquellos que pueden sobreescribirse.
        //Este método se propagada en todas las clases hijas. Eso quiere
        //decir que todas podrán invocarlo. Ahora bien, si una de ellas
        //quisiera implementarlo de forma personalizada puede hacerlo
        //porque el método es virtual. Sobre escribirlo es opcional.
        public virtual void HacerRuido ()
        {
            Console.WriteLine("El animal con nombre {0} hace ruido", Nombre);
        }
    }

    class Vaca : Animal
    {
        public Vaca (string nombre)
        {
            Nombre = nombre;
        }

        public void OrdeñarVaca()
        {
            Console.WriteLine("La vaca {0} esta siendo ordeñada.", Nombre);
        }

        //Se sobreescribe el método heredado del padre
        //y se personaliza. Para ello solo se usa después
        //de la accesibilidad y antes del tipo devuelto
        //la palabra clave override
        public override void HacerRuido()
        {
            Console.WriteLine("La vaca {0} hace muuuuu", Nombre);
        }
    }

    class Oveja : Animal
    {
        public Oveja(string nombre)
        {
            Nombre = nombre;
        }

        public void EsquilarOveja()
        {
            Console.WriteLine("La oveja {0} está siendo esquilada.", Nombre);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Gracias a la herencia podemos usar el 
            //método del padre o sobreescribirlo.
            Vaca vaca = new Vaca("Otis");
            Oveja oveja = new Oveja("Gera");

            vaca.HacerRuido();
            oveja.HacerRuido();


            Console.WriteLine(Environment.NewLine);

            //Tambien gracias al principio de sustitución
            //(POLIMORFISMO) podemos crear listas de ovejas
            //o vacas usando la clase padre. El incoveniente
            //es que no podremos usar los métodos propios
            //de los hijos como OrdeñarVaca de Vaca o EsquilarOveja
            //de Oveja, en el caso de las sobre escrituras de métodos
            //simpre siguen siendo vigentes.
            List<Animal> animales = new List<Animal>()
            {
                new Vaca("Otis"),
                new Oveja("Gera"),
                new Vaca("Flepa"),
                new Oveja("Boni")
            };

            foreach(var animal in animales)
            {
                animal.HacerRuido();
                Console.WriteLine(animal.Nombre);
            }

            Console.Read();

        }
    }
}
