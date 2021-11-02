using System;

namespace GenericosII
{
    class Program
    {
        static void Main(string[] args)
        {
            //TIPOS STRING
            //instanciamos la clase AlmacenObjetos y entre <> especificamos
            //el tipo de datos que utilizará y creamos el array.
            //El primer problema que el compilador no decta que si
            //agregamos un elemento fuera del rango del array es un error
            //y lo mostrara hasta que la aplicacion este en ejecucion.
            AlmacenObjetos<string> archivos = new AlmacenObjetos<string>(4);
            archivos.Agregar("Alexis");
            archivos.Agregar("Luis");
            archivos.Agregar("Maria");
            archivos.Agregar("Ester");

            string nombre = archivos.GetElemento(1);
            Console.WriteLine(nombre);



            //TIPOS EMPLEADO
            AlmacenObjetos<Empleado> archivos2 = new AlmacenObjetos<Empleado>(4);
            archivos2.Agregar(new Empleado(1200));
            archivos2.Agregar(new Empleado(1000));
            archivos2.Agregar(new Empleado(900));
            archivos2.Agregar(new Empleado(800));

            //La ventaja de los genericos es que no necesitamos hacer
            //un casting de tipos. Además nos mostrará en tiempo de
            //compilación los errores de tipos que tengamos.
            Empleado salarioJuan = archivos2.GetElemento(1);
            Console.WriteLine(salarioJuan.GetSalario());

            //DATETIME
            AlmacenObjetos<DateTime> fecha = new AlmacenObjetos<DateTime>(4);
            fecha.Agregar(new DateTime());
            fecha.Agregar(new DateTime());
            fecha.Agregar(new DateTime());
            fecha.Agregar(new DateTime());

            DateTime pfecha = fecha.GetElemento(1);
            Console.WriteLine(pfecha);
        }
    }

    //Clase generica, donde T es cualquier tipo de Objeto.
    //Por convencion se usa 'T' aunque se puede usar cualquier letra o palabra.
    class AlmacenObjetos<T>
    {
        //Esta clase ayuda a crear un array de cualquier
        //objeto o clase que le digamos
        private T[] datosElemento;
        private int i = 0;

        //El constructor crea un array de objetos con la
        //cantidad que le pasemos como parámetro.
        public AlmacenObjetos(int z)
        {
            datosElemento = new T[z];
        }

        public void Agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public T GetElemento(int i)
        {
            return datosElemento[i];
        }

    }

    class Empleado
    {
        private double salario;

        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }

    }
}
