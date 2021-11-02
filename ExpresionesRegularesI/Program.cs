using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ExpresionesRegularesI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Las expresiones regulares son poderosas consultas que podemos hacer en cadenas de texto.
            //Nos evita el uso de complejas lineas de codigo.

            //Explicación de clases de caracteres de expresiones regulares
            //Una clase de caracter es tan solo una secuencia de escape que represenrta a un
            //grupo de caracteres que podrian aparecer en un objeto string.

            /*
            @   = permite el uso de caracteres especiales como '\' dentro de cadenas.
            ""  = marcan el inicio y fin de una cadena.
            \   = indica que el caracter a continuacion tiene un significado especial en la expresión regular y 
                 que por tanto se debe dar trato especial. Por otra parte si el caracter por si mismo tiene significado
                 especial la fleca invertida sirve para tratarlo como un caracter comun y corriente. Ejemplo es el caracter '+'.
            \d  = representa cualquier dígito numérico.
            \D  = cualquier carácter que no sea un dígito.
            \w  = representa cualquier carácter de palabra.
            \W  = cualquier carácter que no sea de palabra.                        _________________________________________________________________________________
            \s  = representa un espacio en blanco.                                | Nota: Un carácter de palabra es cualquier caracter alfanumerico o guión bajo.   |
            \S  = cualquier caracter que no sea un espacio en blanco.             |       Un carácter de espacio en blanco es un espacio, un tabulador, un retorno  | 
            .   = coincide con cualquier caracter individual,                     |       retorno de carro, una nueva linea o un avance de página. Un dígito es     |
                  excepto con el carácter de nueva linea.                         |       cualquier carácter numérico.                                              |
            []  = envuelve conjuntos de caracteres numéricos o de palabras.       |_________________________________________________________________________________| 
            -   = dentro de corchetes representa un rango de caracteres
                  de palabras o numericos.
            ^   = dentro de corchetes significa distinto.

            //CUANTIFICADORES
            *   = En general, cuando este operador se aplica después de un patrón, 
                  el patrón coincide con cero o más ocurrencias.
            +   = En general, cuando este operador se aplica después de un patrón, 
                  el patrón coincide con una o más ocurrencias.
            ?   = cuando se aplica después de un patrón, el patrón 
                  coincide con cero o una ocurrencia.
            {}  = nos permite indicar repetición en instrucciones.
            {n} = cuando se aplica después de un patrón, el patrón coincide
                  exactamente con n ocurrencias. (n representa un número dado).
                  por ejemplo {4} indica que un patrón repite 4 veces.                                             
            {n,} = coincide con menos de n ocurrencias del patrón precedente.(n representa un número dado)
            {n,m} = coincide entre n y m (inclusive) ocurrencias del patrón precedente. (n y m representa un número dado)
            
            COMPOSICIONES
            \s+ = esta composición es útil para verifica si existe uno o varios espacios.



            */
            //Cadenas a evaluar.
            string message = "Hola, mi nombre   nombre es Alexis y mi número de de telefono es +503 7165-2466, tengo otro " +
            "pero es de Guatemala Guatemala +502 5932-4332. Mi web web es http://alexisportafolio.somee.com/";



            //Busca un numero compuesto de 4 digitos en la cadena a evaluar.
            string regularExpresion1 = @"\d\d\d\d ";


            /*
          
            
            Busca un numero compuesto de 4 digitos en la cadena a evaluar. */
            string regularExpresion2 = @"\d{4}";


            //Busca numeros telefónicos que tengan la estructura '1234-1234'
            string regularExpresion3 = @"\d{4}-\d{4}";



            /*
            +   = indica repeticion de una o mas coincidencias.

            Como el simbolo '+' se usa como caracter especial se debe usar '\' para escaparlo y
            usarlo como un caracter cualquiera.
            Busca numeros telefónicos de El Salvador*/
            string regularExpresion4 = @"\+503 \d{4}-\d{4}";


            /*
            | = la barra se usa como un OR logico.
            
            Busca los prefijos +503 o +502*/
            string regularExpresion5 = @"\+503|\+501";


            /*
            () = indica un grupo de caracteres a evaluar.
            ?  = significa que el anterior caracter o grupo de caracteres puede bien estar o no estar y que por tanto debe ser ignorado.

            Ejemplo 1: Busca un sitio web donde no importe si tiene el grupo de caracteres 'www.'
            Ejemplo 2: Busca un sitio web donde no importe si tiene el caracter 's' al final de http.

            */
            string regularExpresion6 = "http://(www.)?alexisportafolio.somee.com/";
            string regularExpresion7 = "https?://alexisportafolio.somee.com/";



            //Regex es una clase que permite el uso de expresiones regulares
            //se pasa como parametro en el constructor la expresion regular
            //que servira de filtro.
            Regex regex = new Regex(regularExpresion4);

            //Luego se usa el método Matches de Regex para indicar la cadena
            //que será evaluada. El metodo devuelve en una colección de las
            //coincidencias encontradas.

            //ICollection<Match> collection = regex.Matches(message);
            MatchCollection collection = regex.Matches(message);

            if (collection.Count > 0)
            {
                Console.WriteLine("Se encontraron las siguientes coincidencias: ");
                foreach(var item in collection)
                {
                    Console.WriteLine(item);
                }
            }
            else Console.WriteLine("Sin resultados.");
        }
    }
}
