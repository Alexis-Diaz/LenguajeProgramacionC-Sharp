using System;
using System.Text.RegularExpressions;

namespace ExpresionesRegularesII
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se define la cadena de prueba.
            string text = "The the quick brown quick fox  fox jumps over the lazy dog  dog .he";


            //A este aun no lo entiendo del todo
            /* 
            ?   = cuando se aplica después de un patrón, el patrón 
                  coincide con cero o una ocurrencia.  
            /b  = inicia la coincidencia estableciendo limite de palabras.
            /b  = finaliza la coincidencia estableciendo limite de palabras.
            (?<word>\w+) = captura una palabra y se almacena en word.
            (\k<word>)   = se compara la palabra alamacenada en word.
             
            Defina una expresión regular para palabras repetidas que estan juntas separadas por n espacio.*/
            string RegularExpresion1 = @"\b(?<word>\w+)\s+(\k<word>)\b";


            /*
            s   = representa un espacio en blanco.
            +   = indica repeticion de una o mas coincidencias.
            \s+ = esta composición es útil para verifica si existe uno o varios espacios.
            
             La siguiente expresion busca dos palabras 'dog' separadas por n espacio */
            string RegularExpresion2 = @"dog\s+dog";

            /*
            +   = indica repeticion de una o mas coincidencias.

            Busca todas las veces que se repite "he" en la cadena*/
            string RegularExpresion3 = @"he+";





            //Se instancia la clase Regex
            //Recibe dos parametros:
            //Param 1 = regular expresion.
            //Param 2 = opciones que modifican la expresion regular

            //RegexOptions.Compiled   = Especifica que la expresión regular se compila en un ensamblado. Esto produce
            //                          ejecución más rápida pero aumenta el tiempo de inicio..
            //RegexOptions.IgnoreCase = La expresion regular debe ignorar mayusculas y minusculas.
            Regex rx = new Regex(RegularExpresion1, RegexOptions.Compiled | RegexOptions.IgnoreCase);

          

            // Se le pasa la cadena a evaluar al metodo Matches
            // Devuel una colection de las coincidencias
            MatchCollection matches = rx.Matches(text);

            // Informe el número de coincidencias encontradas.
            Console.WriteLine("{0} coincidencias encontradas en:\n   {1}", matches.Count, text);

            // Recorrido
            foreach (Match match in matches)
            {
                //esta parte sirve solamente con la primera expresion regular

                //Como se captura por grupo es necesario guardar cada grupo
                //en un objeto de tipo GroupCollection, notar que ahora se puede
                //acceder a tres cosas: su valor, indice donde se encuentran en
                //la cadena 'text' por medio de su posición 0 y posicion 1.
                GroupCollection groups = match.Groups;
                Console.WriteLine("'{0}' se encuentra apartir de la posición {1} y se repite a partir de la posición {2}",
                                  groups["word"].Value,//la clave 'word' se le asigna en la declaracion de la expresion regular
                                  groups[0].Index,
                                  groups[1].Index);

                Console.WriteLine($"'{match}'");
            }
        }
    }
}
