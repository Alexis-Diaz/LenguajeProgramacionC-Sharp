using System;

namespace Herencia
{
    class Program
    {
        //Para hacer herencia se usa los dos puntos
        //Cada vez que instanciamos un objeto de alguna
        //clase que hayamos creado, despues del punto siempre
        //habran cuatrp metodos: Equals, GetHashCode, GetType
        //y ToString. Pues bien estos métodos se estan
        //heredando de la superclase Object, a pesar de que
        //no lo hacemos explicitamente, en otras palabras,
        //todos los objetos que creemos heredaran de Object
        //queramos o no queramos.

        //Al heredar debemos tener en cuenta que por cada
        //nueva instancia se hara un llamado al contructor de
        //la clase padre. Cuando este no se crea, ni se crea en
        //las clases que heredan, todo se da por implicito. Por
        //ejemplo en la clase base se crea un contructor :base(){}
        //que lo que hace es llamar al contructor padre para
        //que este inicialice el estado de los objetos. Esto
        //cambia cuando creamos un constructo en la clase padre.
        //Cuando esto ocurre estonces necesitaremos llamar
        //explicitamente el constructor de la clase padre desde
        //las clases hijas.
        static void Main(string[] args)
        {
            Persona persona= new Persona("Alexis");
            Caballo caballo = new Caballo("Babieca");
            Gorila gorila = new Gorila("Peca");

            persona.Respirar();
            caballo.Respirar();
            gorila.Respirar();

            //PRINCIPIO DE SUSTITUCION
            //Este principio establece que todos los
            //objetos seran igual a su clase padre y por
            //tanto la clase padre puede contener cualquier
            //instancia que corresponda a una clase hija.
            //El problema que se presenta al hacer una instancia
            //de la clase padre es que el objeto creado no será
            //capaz de alcanzar los metodos y propiedades del hijo.
            Mamifero caballo2 = new Caballo("Copito");

            //esto es lo mismo que lo anterior
            Mamifero mamifero = new Mamifero("mamifero");//esta es una instancia comun y corriente
            Gorila gorila2 = new Gorila("gorila");//esta es una instancia comun y corriente
            
            mamifero = gorila2;//aqui se aplica el principio de sustitucion.

            mamifero.cuidarHijos();

            //por tanto concluimos que la clase Object que esta arriba
            //de todo puede contender cualquier clase de objeto
            Object persona3 = new Persona("Elena");
            Object caballo3 = new Caballo("Olaf");
            Object gorila3 = new Gorila("Veuj");

            //APLICACION DEL PRINCIPIO DE SUSTITUCION
            //Imaginar la siguiente situacion: Queremos formar un
            //pero que combine personas, caballos y gorilas. En principio
            //esto no se puede ya que solo podemos hacer array de cada uno
            //de los elementos. Pero si usamos la clase padre si que
            //podrimaos. En el siguiente ejemplo hacemos un array de los
            //tres objetos creados al principio:.

            Mamifero[] milista = new Mamifero[3];
            milista[0] = persona;
            milista[1] = caballo;
            milista[2] = gorila;

            milista[1].cuidarHijos();
        }
    }

    class Mamifero:Object//todas las clases heredan de Object de forma predeterminada
    {
        private string NombreSerVivo;

        //constructor de clase padre
        public Mamifero(string NombreSerVivo)
        {
            this.NombreSerVivo = NombreSerVivo;
        }
       
        public void Respirar()
        {
            Console.WriteLine($"{NombreSerVivo} es capaz de respirar");
        }
        public void cuidarHijos()
        {
            Console.WriteLine($"{NombreSerVivo} cuida sus niños hasta que crecen");
        }

    }

    class Persona:Mamifero
    {
        //constructo clase hija
        //con base llamamos el constructor del padre
        //el parametro Nombre lo pasamos al padre
        public Persona (string Nombre) : base(Nombre)
        {
            //aqui se puede dar un estado 
            //inicial a Persona
        }
        public void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Caballo : Mamifero
    {
        public string nombreCaballo {get;set;}
        //constructo clase hija
        //con base llamamos el constructor del padre
        //el parametro Nombre lo pasamos al padre
        public Caballo(string Nombre) : base(Nombre)
        {
            //aqui se puede dar un estado 
            //inicial a Persona
        }
        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }

    class Gorila:Mamifero
    {
        //constructo clase hija
        //con base llamamos el constructor del padre
        //el parametro Nombre lo pasamos al padre
        public Gorila(string Nombre) : base(Nombre)
        {
            //aqui se puede dar un estado 
            //inicial a Persona
        }
        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}
