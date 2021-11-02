using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            //ARRAY
            //Cuando se crea un array, inicialmente toma
            //los valores que el tipo tiene por defecto.
            //Para tipos int y double es 0, para string es una cadena
            //vacia, para objetos es null, para boolean es false.
            //Se pueden crear array de varias formas:

            //Declarando la variable e iniciandola mas tarde dando su longitud
            int[] ListaNumeros2;
            //algun codigo...
            ListaNumeros2 = new int[3];

            //Declaracion e iniciacion
            int[] ListaNumeros = new int[5];

      
            //Declaracion, iniciación y asignacion de valores segun el indice
            int[] ListaNumeros3 = new int[2];
            ListaNumeros3[0] = 23;
            ListaNumeros3[1] = 24;

            //En linea asignando valores de forma dinamica, en este
            //caso no es necesario declarar la longitud que tendrá,
            //esta es la forma más flexible.
            int[] ListaNumeros1 = { 1, 2, 3, 4, 5, 6, 5 };


            //Declaracion de array de objeto en linea
            //Los array de esta clase siguen las mismas normas anteriores
            Personas[] ListaPersonas =
            {
                new Personas ("Alexis", "Diaz", 32),
                new Personas ("Osmin", "Lue", 21),
                new Personas ("Jose", "Diaz", 19)

            };


            //Declarando array de tipo y objetos anonimos. En estos casos el compilador
            //le asigna el tipo. En el primer caso es de tipo int y en el segundo como
            //no existe la clase el compilador crea objetos de clases anonimas.
            var ListaNumeros4 = new[] { 1, 2, 3, 4, 45 };

            var Prgramador = new[]
            {
               new { Nombre = "Alexis", Edad = 20},
               new { Nombre = "Osmin", Edad = 23}
            };

            //RECORRIDOS
            
            //bucle for
            for(int i=0; i<ListaNumeros1.Length; i++)
            {
                Console.WriteLine(ListaNumeros1[i]);//output  1, 2, 3, 4, 5, 6, 5
            }

            for (int i = 0; i < ListaPersonas.Length; i++)
            {
                Console.WriteLine(ListaPersonas[i].Nombre);//output  1, 2, 3, 4, 5, 6, 5
            }

            //foreach
            foreach (var item in ListaPersonas)
            {
                Console.WriteLine(item.Nombre);
            }

            //EXCEPCIONES
            //Cuando se intenta acceder a un elemento de una array
            //que no existe se produce la excepcion
            //System.IndexOutOfRangeException
        }
    }

    class Personas
    {
        public Personas(string Nombre,string Apellido, int pEdad)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = pEdad;
        }

        public string Nombre;
        public string Apellido;
        public int Edad;
    }
}
