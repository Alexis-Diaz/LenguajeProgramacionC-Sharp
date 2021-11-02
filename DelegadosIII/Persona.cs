using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosIII
{
    class Programa
    {

        public static void MiMetodo()
        {
            List<int> numero = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Uso de expresion lambda en el metodo FindAll
            List<int> numerosPares = numero.FindAll(i => i % 2 == 0);

            foreach (int item in numerosPares) Console.WriteLine(item);

            Console.WriteLine();

            //Uso de expresion lambda para un foreach
            numerosPares.ForEach(num => Console.WriteLine(num));

            Console.WriteLine();

            //Para agregar mas de una linea de codigo en el cuerpo de 
            //una expresion lambda se usa llaves
            numerosPares.ForEach(num =>
            {
                Console.WriteLine("Numero par:");
                Console.WriteLine(num);
            });


            List<Personas> gente = new List<Personas>();

            Personas p1 = new Personas();
            p1.Nombre = "Juan";
            p1.Edad = 19;

            Personas p2 = new Personas();
            p2.Nombre = "Maria";
            p2.Edad = 23;

            Personas p3 = new Personas();
            p3.Nombre = "Luis";
            p3.Edad = 18;

            //Uso de expresion lambda con delegado
            //Cuando la empresion lambda recive mas de dos
            //parametros se usan parentesis.
            //La expresion lambda devuelve true o false
            ComparaPersonas comparaEdad = new ComparaPersonas((edad1, edad2)=> edad1==edad2);

            Console.WriteLine(comparaEdad(p1.Edad, p2.Edad));
        }

        public delegate bool ComparaPersonas(int edad1, int edad2);
    }

    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => Edad1; set => Edad1 = value; }
        public int Edad1 { get => edad; set => edad = value; }
    }
}
