using System;

namespace Polimorfismo
{
    class Program
    {
        //El polimorfismo (muchas formas) se basa en las herencias.
        //Este pilar trata sobre el comportamiento que
        //nuestros objetos y metodos pueden tener en determinadas
        //circunstancias. Para este tema se utilizan las palabras
        //reservadas new, virtual y override.
        //En los siguiente ejemplos se trata de explicar el uso de
        //estos términos.

        //Debemos notar que la clase padre implementa sus propios
        //metodos que seran heredados por sus hijos, en este punto
        //es importante entender que si las clases hijas tratan
        //de definir un metodo que coincide en nombre y en tipo y numeros
        //de parametros visual studio marcará una advertencia diciendo
        //que este metodo ya esta definido en la clase padre. Para
        //eliminar esta advertencia es necesario usar la palabra reservada
        //new, con esto logramos ocultar o sustituir el metodo de la clase
        //padre por el metodo del hijo (ver clase Cajero).
        
        //Por otra parte cuando lo que necesitamos es sobreescribir el
        //metodo de la clase padre por el metodo de la clase hija usamos
        //la palabra virtual en la definicion del metodo de la clase
        //padre y usamos la palabra override en la definicion del metodo
        //de la clase hija. En primera vista no se ve la utilidad, pero
        //si lo pensamos esto nos da la posibilidad de acondicionar el
        //metodo segun se necesite por cada clase, si no se desea
        //personalizar el metodo entonces podemos usar el que se ha
        //definido en la clase padre, que en este caso llamaremos,
        //metodo genérico.
        static void Main(string[] args)
        {
            //hacemos uso de los metodos genericos
            Secretaria secretaria = new Secretaria("Maria");
            secretaria.Descansar();

            //hacemos uso de un metodo que ocultó el del padre.
            Cajero cajero = new Cajero("Alexis");
            cajero.Trabajar();

            //hacemos uso de un metodo sobreescrito
            Gerente gerente = new Gerente("Adalberto");
            gerente.Pagar();


        }
    }

    class Empleado
    {
        //el protected es como el private con la diferencia
        //que es accedido desde las herencias.
        protected string nombre;//campo

        //constructor clase padre
        public Empleado (string nombre)
        {
            this.nombre = nombre;
        }

        //metodos genericos
        public void Descansar()
        {
            Console.WriteLine($"{nombre} empezó a descansar");
        }

        public void Trabajar()
        {
            Console.WriteLine($"{nombre} empezó a trabajar");
        }

        public virtual void Pagar()
        {
            Console.WriteLine($"{nombre} recibió el pago");
        }
    }

    class Secretaria : Empleado
    {
        public Secretaria(string nombre) : base(nombre)
        { 
        }
    }

    class Cajero:Empleado
    {
        public Cajero (string nombre) : base(nombre)
        {
        }

        //con la palabra new ocultamos o sustituimos el metodo
        //de la clase padre por este metodo
        new public void Trabajar()
        {
            Console.WriteLine($"{nombre} tomó su puesto como cajero del banco.");
        }
    }
    

    class Gerente:Empleado
    {
        public Gerente(string nombre) : base(nombre)
        { 
        }

        //con la palabra override podemos sobreescribir metodos
        //virtuales de la clase padre
        public override void Pagar()
        {
            Console.WriteLine($"{nombre} le pagó a sus empleados.");
        }
    }
}
