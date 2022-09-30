using System;

namespace Estructuras
{
    class Program
    {
        //Una instancia de clase se guarda en la memoria heap,
        //mientras que una struct al igual que los valores 
        //primitivos se guardan en la memoria stack. Los valores
        //almacenados en la memoria heap al ser leidos por
        //el compilador solo toman su referencia (valores por
        //referencia) mientras que los valores en la memoria stack
        //usan el valor directamente.

        //Cuando un valor es referenciado se da el fenómeno que todas
        //las variables que usan ese valor serán cambiadas cuando solo
        //una de ellas cambie. Mientras que las referencias por valor
        //solo cambian el valor de la variable modificada pues cada
        //variable en realidad hace una copia del valor que posee.

        //¿Cuando usar structuras?
        //Es bueno usarlas cuando el rendimiento es importante, ya que
        //la memoria stack es de acceso rápido con grandes cantidades de datos.
       

        static void Main(string[] args)
        {
            //CLASES
            //La instancia de clase Empleado se almacena en la memoria heap
            //lo que significa que todas las variables que apuntan a ese
            //valor cambiarán al modificarse una de ellas.

            //Se declaran 3 variables que apuntan al mismo objeto em
            Empleado em = new Empleado(500,129);
            var variable1 = em;
            var variable2 = em;
            var variable3 = em;

            //se cambia el valor de una de las variables
            variable2.CambiarSalario(variable2, 100);

            //se verifica el valor de cada variable y en
            //efecto todas sufren cambios al cambiar solo una.
            Console.WriteLine(em);
            Console.WriteLine(variable1);
            Console.WriteLine(variable2);
            Console.WriteLine(variable3);

            Console.WriteLine("\n----------------------------\n");




            //ESTRUCT
            //Esta instancia de struct se almacena en la memoria stack
            //lo que significa que todas las variables hacen una copia
            //del valor que se le asigna, esto significa que cuando
            //el valor de una de las variables cambie, las demás
            //continuaran sin cambios.

            //Se declaran 3 variables que hacen copia del mismo objeto emp
            Empleados emp = new Empleados(500, 129);
            var variable4 = emp;
            var variable5 = emp;
            var variable6 = emp;

            //se cambia el valor de una de las variables
            variable5.CambiarSalario(variable5, 100);

            //se verifica el valor de cada variable y se comprueba
            //que solo cambia la variable alterada. (Nota: En este caso
            //la variable que ha cambiado no es ninguna de estas,
            //en realidad, la que ha cambiado es la variable que se
            //creó cuando el metodo CambiarSalario fue llamado).
            Console.WriteLine(emp);
            Console.WriteLine(variable4);
            Console.WriteLine(variable5);
            Console.WriteLine(variable6);
        }
    }

    class Empleado
    {
        private double salarioBase, comision;
        public Empleado(double salarioBase, double comision)
        {
            this.salarioBase = salarioBase;
            this.comision=comision;
        }

        //Sobre escribimos el método virtual que se hereda de la super
        //clase Object, el cual sirve para imprimir un mensaje al 
        //imprimir directamente el objeto instanciado.
        public override string ToString()
        {
            return $"El salario base es: {salarioBase}, y la comision es: {comision}.";
        }

        //Método cambiar salario
        public void CambiarSalario(Empleado em, double aumento)
        {
            //Notar que estamos cambiando solo los valores del objeto em
            //pasado como parámetro, aun asi todos sufrirán el cambio.
            em.salarioBase += aumento;
            em.comision += aumento;
            Console.WriteLine("impresion desde el método CambiarSalario");
            Console.WriteLine(em);
            Console.WriteLine("fin de impresion desde el método CambiarSalario\n");

        }

    }

    struct Empleados
    {
        //CARACTERISTICAS
        //No permiten los constructores por defecto, hay que definirlos.
        //El compilador no inicia los campos. Se pueden iniciar desde el constructor
        //No puede haber sobrecarga de constructores
        //No heredan de otras clases pero pueden implementar interfaces
        //Son selladas (sealed).
        private double salarioBase, comision;
        public Empleados(double salarioBase, double comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }

        //Sobre escribimos el metodo virtual que se hereda de la super
        //clase Object, el cual sirve para imprimir un mensaje al 
        //imprimir directamente el objeto instanciado.
        public override string ToString()
        {
            return $"El salario base es: {salarioBase}, y la comision es: {comision}.";
        }

        //metodo cambiar salario
        public void CambiarSalario(Empleados emp, double aumento)
        {
            //El parametro emp crea su propia copia del objeto.
            emp.salarioBase += aumento;
            emp.comision += aumento;

            Console.WriteLine("impresion desde el metodo CambiarSalario");
            Console.WriteLine(emp);
            Console.WriteLine("fin de impresion desde el metodo CambiarSalario\n");

        }

    }
}
