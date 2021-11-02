using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsIV
{
    class Diccionario
    {
        public static void MiMetodo()
        {
            //Un dictionary es muy práctico pero consume mas recursos.
            //En terminos basicos son colecciones que guardar elementos
            //con clave valor. Cada elemento en realidad es un struct
            //KeyValuePair por lo que al momento de recorrer un diccionario
            //es necesario ingresar al valor y clave para ver su contenido.
            Dictionary<string, int> edades = new Dictionary<string, int>();

            //rellenar el dictionary
            //Usando el metodo del diccionario Add
            edades.Add("Juan", 18);
            edades.Add("Ana", 23);
            //Usando el indice o llave.
            edades["Maria"] = 33;
            edades["Jose"] = 20;

            foreach(KeyValuePair<string, int>personas in edades)
            {
                Console.WriteLine("Nombre: " + personas.Key + " Edad: " + personas.Value);
            }
        }
    }
}
