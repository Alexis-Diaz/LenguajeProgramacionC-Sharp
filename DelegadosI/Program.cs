using System;

namespace DelegadosI
{
    class Program
    {
        //DEFINICION DE DELEGADO:
        //Los delegados son como apuntadores hacia otros métodos
        //o funciones que llaman a otros metodos. Esto permite 
        //reutilizar codigo.

        //Los delgados pueden apuntar a las funciones desde
        //cualquier ambito o alcance.

        //un delegado es como un hibrido entre una clase y
        //una funcion. Por ejemplo aunque es metodo se puede
        //hacer una especie de instancia de el para ser utilizado
        //pero funciona como un metodo cualquiera al momento de
        //ser llamado.

        //SINTAXIS:
        //Se escribe la palabra reservada delegate para indicar que es un
        //método que delega la tarea a otro metodo cuando este es llamado.

        //El delegado debe coincidir exactamente con la misma
        //estructura del mátodo al que apuntará con la 
        //diferencia que este lleva la palabra clave delegate.

        //Este delegado podrá apuntar a un método que no devuelva nada y 
        //que no reciba parámetros.
        delegate void ObjetoDelegadoSinParametros();

        //Este delegado podrá apuntar a un método que no devuelva nada y
        //que reciba un parámetro de tipo string.
        delegate void ObjetoDelegadoConParametros(string msj);

        static void Main(string[] args)
        {
           
            //Para hacer que el delegado apunte a una función compatible
            //debemos instanciarlo como si de una clase se tratara. Dentro
            //de su constructor le pasamos el método al que apuntará.
            ObjetoDelegadoSinParametros Delegado1 = new ObjetoDelegadoSinParametros(MensajeBienvenida.SaludoBienvenida);
            //Utilizacion del delegado para llamar el método SaludoBienvenida()
            Delegado1();


            Console.WriteLine();


            //Se apunta a un metodo compatible con el delegado, notar que no es 
            //necesario usar los parentesis pues no deseamos ejecutar el metodo
            //sino unicamente apuntar a su referencia.
            ObjetoDelegadoConParametros Delegado2 = new ObjetoDelegadoConParametros(MensajeDespedida.SaludoDespedida);
            //Utilizacion del delegado para llamar el metodo SaludoDespedida(),
            //es en este punto que le pasamos el parametros que se necesita.
            Delegado2("Adios, hasta pronto!!!");
        }
    }

    class MensajeBienvenida
    {
        //metodo sin parametros
        public static void SaludoBienvenida()
        {
            Console.WriteLine("Bienvenido");
        }
    }

    class MensajeDespedida
    {
        //metodo con parametros
        public static void SaludoDespedida(string msj)
        {
            Console.WriteLine($"Mensaje de despedida: {msj}");
        }
    }
}
