using System;

namespace GenericosIII
{
    class Program
    {
        //Al crear clases genericas, el problema que presentan es
        //que cualquier clase podra usarla ya que las clases genericas
        //las soportan. A veces no es esta la funcion que esperamos,
        //asi que necesitaremos de alguna forma decirle a la clase 
        //generica que restrinja su uso solo para ciertas clases que
        //cumplan con cierta caracteristicas.

        static void Main(string[] args)
        {

            //La clase generica se adapta a las clases que implementan la Interface
            AlmacenEmpleados<Director> directores = new AlmacenEmpleados<Director>(3);
            directores.agregar(new Director(2000));
            directores.agregar(new Director(2000));
            directores.agregar(new Director(2000));


            //La clase generica rechaza las clases que no implementan la Interface
            AlmacenEmpleados<Estudiante> estudiantes = new AlmacenEmpleados<Estudiante>(3);
            estudiantes.agregar(new Estudiante(13));
            estudiantes.agregar(new Estudiante(15));
            estudiantes.agregar(new Estudiante(12));

        }
    }

    //Creamos la clase de tipos genéricos con restricción
    //sintaxis:
    //where T:IParaEmpleados = donde la clase pasada por parametro 'T'
    //herede o implemente la interfaz IParaEmpleados.

    class AlmacenEmpleados<T> where T:IParaEmpleados
    {
        private int i = 0;
        private T[] datosEmpleados;
        public AlmacenEmpleados(int z)
        {
            datosEmpleados = new T[z];
        }
       

        public void agregar (T obj)
        {
            datosEmpleados[i] = obj;
            i++;
        }

        public T getEmpleados(int i)
        {
            return datosEmpleados[i];
        }
    }


    //Creamos una interface que obliga a todas las que la hereden
    //que implementen el metodo getSalario();
    interface IParaEmpleados
    {
        double getSalario();
    }

    class Director:IParaEmpleados
    {
        public Director(double salario)
        {
            this.salario = salario;
        }

        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }

    class Secretaria:IParaEmpleados
    {
        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        private double salario;
        public double getSalario()
        {
            return salario;
        }
    }

    class Electricista:IParaEmpleados
    {
        public Electricista(double salario)
        {
            this.salario = salario;
        }

        private double salario;
        public double getSalario()
        {
            return salario;
        }
    }
    

    //clase que no implementa interface
    class Estudiante
    {
        private double edad;
        public Estudiante (double edad)
        {
            this.edad = edad;
        }

        public double getEdad()
        {
            return edad;
        }
    }

}
