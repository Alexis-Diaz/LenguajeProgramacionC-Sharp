using System;

namespace GenericosI
{
    class Program
    {
        //La programacion generica nos ayuda a reutilizar el codigo.
        //Consiste en crear clases que sean capaz de manejar cualquier
        //tipo de objetos. Esto ayuda a tener mayor sencilles del 
        //codigo, reutilizacion del mismo en diferentes escenarios y
        //comprobacion de errores en tiempo de compilacion.

        //Claro se puede lograr algo parecido a la programacion
        //generica heredando la superclase Object. Sin embargo,
        //el problema de usar esto con grandes cantidades de datos
        //es que tendremos que hacer uso continuo de casting lo que
        //claramente complica el codigo y ademas los errores no se podran
        //percibir en tiempo de compilacion sino hasta que el programa este
        //en ejecucion.
        static void Main(string[] args)
        {
            //TIPOS STRING
            //instanciamos la clase AlmacenObjetos y creamos el array
            //el primer problema que el compilador no decta que si
            //agregamos un elemento fuera del rango del array es un error
            //y lo mostrara hasta que la aplicacion este en ejecucion.
            AlmacenObjetos archivos = new AlmacenObjetos(4);
            archivos.Agregar("Alexis");
            archivos.Agregar("Luis");
            archivos.Agregar("Maria");
            archivos.Agregar("Ester");

            //El otro problema es que al momento de imprimir el elemento
            //debemos hacer un casting al tipo que queremos convertir.
            string nombre = archivos.GetElemento(1).ToString();
            Console.WriteLine(nombre);



            //TIPOS EMPLEADO
            AlmacenObjetos archivos2 = new AlmacenObjetos(4);
            archivos2.Agregar(new Empleado(1200));
            archivos2.Agregar(new Empleado(1000));
            archivos2.Agregar(new Empleado(900));
            archivos2.Agregar(new Empleado(800));

            //Este codigo comentado muestra el problema al usar la 
            //herencia para la construccion de array. Si observamos
            //el compilador no muestra error aun cuando el tipo que
            //manejamos es tipo Empleado y aqui lo estamos parseando
            //a tipo string, logicamente al ejecutar el programa esto 
            //dará error.

            //string salarioJuan = (string)archivos2.GetElemento(1);
            //Console.WriteLine(salarioJuan);

            Empleado salarioJuan = (Empleado)archivos2.GetElemento(1);
            Console.WriteLine(salarioJuan.GetSalario());
        }   
    }

    class AlmacenObjetos
    {
        //Esta clase ayuda a crear un array de cualquier
        //elementos que le digamos
        private Object[] datosElemento;
        private int i = 0;

        //El constructor crea un array de objetos con la
        //cantidad que le pasemos como parámetro.
        public AlmacenObjetos(int z)
        {
            datosElemento = new Object[z];
        }

        public void Agregar(Object obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public Object GetElemento(int i)
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
