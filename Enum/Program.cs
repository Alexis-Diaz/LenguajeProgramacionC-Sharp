using System;

namespace Enum
{
    class Program
    {
        //Los tipos enumerados se pueden crear como si fuera una clase
        //(namespace) o dentro de una clase , de las dos es mas frecuente
        //crear en el namespace para que sean mas globales.
        static void Main(string[] args)
        {
            //Cuando creamos una variable del mismo tipo enum, el
            //valor que se imprime en consola es la clave
            //mientras que si lo parseamos a int obligamos al 
            //compilador que imprima el valor

            Estaciones claveEnum = Estaciones.Primavera;

            int valor = (int)Estaciones.Primavera;

            //Si queremos manejar la clave como un string tambien
            //es posible con el metodo ToString() de la clase Object
            string claveString = claveEnum.ToString();


            Console.WriteLine(claveEnum);
            Console.WriteLine(valor);

            Salario salario = new Salario();
            salario.Imprimir();
        }

        enum diasDeLaSemana
        {
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado,
            Domingo
        }
    }

    enum Estaciones
    {
        //El compilador le asigna un indice a cada una de las
        //constantes, los indice van a partir del 0. Aunque 
        //podemos cambiar esto a nuestra conveniencia. Se debe
        Primavera,
        Verano,
        Otoño,
        Invierno
    }
}
