using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    public class Clase
    {
        //.Net nos ofrece librerias que podemos utilizar. Esta librerias tienen
        //clases y métodos que pueden sernos útiles en la creación de programas.
        //Por ejemplo, si escribimos un numero y escribimos punto veremos que 
        //tenemos a nuestra disposicion metodos de la structura Int.

        public void MiMetodo()
        {
            //La estructura Int ofrece entre otros el método CompareTo. Este
            //método indica si el valor de la instancia es menor (-1), igual (0) 
            //o mayor (1) que el valor pasado por parámetro.
            int Value = 3.CompareTo(2);

            Console.WriteLine(Value);

            //Si vamos a su definición Visual Studio no nos permite editar el
            //codigo de la structure Int ya que está protegida.

            //Ahora bien, si por algún motivo desearamos agregarle una nueva
            //función a la estructura podemos hacer los siguiente:
        }
    }

    //Para lograrlo necesitamos hacer un método de extensión. Esto no altera
    //la estructura solo le agrega métodos desde afuera.

    //Se crea una clase que debe ser estática, esta debe ser de nivel superior y no estar
    //anidada dentro de otra clase.
    public static class IntegerExtensionMethods
    {
        //Dentro creamos un metodo.
        //this int valor: indica al tipo que se le agregará el método. En este caso al tipo int.
        //En este parámetro podemos indicar prácticamente cualquier tipo.
        //
        //int exponente: parámetro que le pasaremos, pueden ser más.
        public static double ElevadoALa(this int valor, int exponente)
        {
            return Math.Pow(valor, exponente);
        }
    }

    public class MetodosDeExtension
    {
        public void UsarExtension()
        {
            //Para usar el nuevo método de extesión
            //solo se accede por medio de punto.
            Console.WriteLine(3.ElevadoALa(9));
            Console.WriteLine(8.ElevadoALa(2));
        }
    }
}
