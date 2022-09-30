using System;

namespace Herencia
{
    //HERENCIA
    //Para hacer herencia se usa los dos puntos después del
    //nombre de la clase.
    //
    //Cada vez que instanciamos un objeto de alguna
    //clase que hayamos creado, después del punto siempre
    //habran cuatro métodos: Equals, GetHashCode, GetType
    //y ToString. Pues bien estos métodos se estan
    //heredando de la superclase Object, a pesar de que
    //no lo hacemos explícitamente. En otras palabras, todos
    //los objetos que creemos siempre heredaran de Object.
    //
    //Al heredar debemos tener en cuenta que por cada
    //nueva instancia se hará un llamado al contructor de
    //la clase padre. Cuando este no se crea en la clase padre,
    //ni se crea en las clases que heredan (hijas), todo se da
    //por implícito. Por ejemplo, en la clase base se crea
    //un contructor :base(){} que, lo que hace es llamar al
    //contructor padre para que este inicialice el estado del
    //nuevo objeto. Esto cambia cuando creamos un constructor en
    //la clase padre. Cuando esto ocurre, entonces necesitaremos llamar
    //explicitamente el constructor de la clase padre desde
    //las clases hijas.

    //A continuación se crea una clase que servirá de base o padre para otras clases
    //que serán denominadas las clase hijas.
    class Mamifero : Object //Todas las clases heredan de Object de forma predeterminada
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
        public void CuidarHijos()
        {
            Console.WriteLine($"{NombreSerVivo} cuida sus niños hasta que crecen");
        }

    }

    //Ahora creamos las clases hijas que heredaran de la clase padre sus propiedades y
    //todos sus métodos. Esto significa que desde las clases hijas seremos capaces
    //de usar las propiedades y métodos del padre. Además cada clase podrá tener sus
    //propias propiedades y métodos personalizados. Recordar que la herencia se representa
    //con los dos puntos (:).
    class Persona : Mamifero
    {
        //Constructor clase hija
        //Con base llamamos el constructor del padre
        //El parámetro Nombre lo pasamos al padre
        public Persona(string Nombre) : base(Nombre)
        {
            //aqui se puede dar un estado 
            //inicial a los objetos de Persona
        }

        //Este método es propia de la clase hija Persona
        public void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Caballo : Mamifero
    {
      
        //Constructor clase hija.
        //Con base llamamos el constructor del padre.
        //El parámetro Nombre lo pasamos al padre.
        public Caballo(string Nombre) : base(Nombre)
        {
            //aqui se puede dar un estado 
            //inicial a Persona
        }

        //Esta propiedades y métodos propios de la clase hija Caballo.
        public string NombreCaballo { get; set; }

        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }

    class Gorila : Mamifero
    {
        //Constructor clase hija.
        //Con base llamamos el constructor del padre.
        //El parámetro Nombre lo pasamos al padre.
        public Gorila(string Nombre) : base(Nombre)
        {
            //aqui se puede dar un estado 
            //inicial a Persona
        }

        //Este método es propia de la clase hija Gorila
        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }


    class Program
    {
      
        static void Main(string[] args)
        {
            //HERENCIA EN ACCIÓN
            //Se realizan las instancias de las clases hijas
            Persona persona= new Persona("Alexis");
            Caballo caballo = new Caballo("Babieca");
            Gorila gorila = new Gorila("Peca");

            //Todas pueden acceder por herencia al método de 
            //la clase padre.
            persona.Respirar();
            caballo.Respirar();
            gorila.Respirar();


            //PRINCIPIO DE SUSTITUCIÓN
            //Este principio establece que todos los
            //objetos seran igual a su clase padre y por
            //tanto la clase padre puede contener cualquier
            //instancia que corresponda a una clase hija.
            //El problema que se presenta al hacer una instancia
            //de la clase padre es que el objeto creado no será
            //capaz de alcanzar los métodos y propiedades del hijo.
            //Vemos como la clase padre Mamifero es capaz de contener 
            //a sus hijas.
            Mamifero caballo2 = new Caballo("Copito");

            //Esto es lo mismo que lo anterior
            Mamifero mamifero = new Mamifero("mamifero");//esta es una instancia común y corriente
            Gorila gorila2 = new Gorila("gorila");//esta es una instancia común y corriente
            
            mamifero = gorila2;//aqui se aplica el principio de sustitución.

            mamifero.CuidarHijos();

            //Lo anterior nos ayuda a concluir que la clase Object que esta arriba
            //de todo puede contender cualquier clase de objeto
            Object persona3 = new Persona("Elena");
            Object caballo3 = new Caballo("Olaf");
            Object gorila3 = new Gorila("Veuj");

            //APLICACION DEL PRINCIPIO DE SUSTITUCIÓN
            //Imaginar la siguiente situación: Queremos formar un array
            //pero que combine personas, caballos y gorilas. En principio
            //esto no se puede ya que solo podemos hacer array de cada uno
            //de los elementos. Pero si usamos la clase padre si que
            //podrímaos. En el siguiente ejemplo hacemos un array de los
            //tres objetos creados al principio:.

            Mamifero[] milista = new Mamifero[3];
            milista[0] = persona;
            milista[1] = caballo;
            milista[2] = gorila;

            milista[1].CuidarHijos();
        }
    }

    
}
