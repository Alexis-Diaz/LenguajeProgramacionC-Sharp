using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosII
{
    class Programa
    {
        public static void MiMetodo ()
        {
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

            Personas p4 = new Personas();
            p4.Nombre = "Alexis";
            p4.Edad = 15;


            gente.AddRange(new Personas[]{ p1,p2,p3,p4});


            Predicate<Personas> DelegadoPredicado = new Predicate<Personas>(ExistePersona);


            //El método Exists itera la lista de elementos
            //para verificar si el elementos existe de acuerdo
            //al filtro del predicado, si el elemento existe
            //el metodo Exists devuelve true.

            //Nota curiosa: Aunque el metodo Exists recibe como parametro
            //un predicado me doy cuenta que si le paso el metodo 
            //ExistePersonas de forma directa tambien funciona ja ja ja.
            bool existe = gente.Exists(DelegadoPredicado);
            if (existe)Console.WriteLine("Hay personas llamadas Juan");
            else Console.WriteLine("No hay personas llamadas Juan");
        }


        //Este metodo comprueba la existencia
        //de una persona con nombre Juan.
        static bool ExistePersona(Personas persona)
        {
            if (persona.Nombre == "Juan") return true;
            else return false;
        }
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
