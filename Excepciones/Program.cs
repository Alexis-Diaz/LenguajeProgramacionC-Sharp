using System;

namespace Excepciones
{
    class Program
    {
        //Las excepciones son errores en tiempo de ejecucion que escapan al
        //control del programador.
        //Existen diferentes tipos de excepciones:

        // *System.Exception => clase padre que captura todo tipo de excepciones.
        // *System.FormatException => se da cuando el formato introducido es incorrecto al que se espera.
        // *System.OverFlowException => se da cuando el valor ingresado se desborda o sobrepasa al valor que puede contener el tipo.
        // *System.IO.FileNotFoundException => se da cuando no se encuentra el archivo en los recurso de la maquina (ver ejemplo en el proyecto EjemploFinally).
        // *System.InvalidCastException => se da cuando se trata de convertir un valor a otro tipo que no corresponde.

        //Se puede manejar excepciones definidas por cada error, esto permite
        //tratar cada error de manera personalizada; para ello
        //se puede concatenar al try varios catch con el tipo de error a
        //capturar.

        //Sin embargo si son muchas las excepciones que se pueden dar, se
        //puede utilizar la clase padre de las excepciones,
        //la clase es Exception que captura todo tipo de excepciones de
        //forma general. Ahora bien, al utilizar este tipo de excepciones
        //debemos tomar en cuenta que debemos cumplir ciertas reglas si 
        //queremos dar un tratamiento especial a ciertas excepciones. Esta 
        //reglas se explican en los dos siguientes ejemplos.

        //
        static void Main(string[] args)
        {
            //EjemploUno();
            //EjemploDos();
            EjemploTres();
        }

        static void EjemploUno()
        {
            //PROGRAMA: ADIVINAR EL NUMERO
            int intentos = 0;
            int miNumero;
            Random numeroRandom = new Random();
            int random = numeroRandom.Next(1, 100);//genera un numero random entre 1 y 100

            Console.WriteLine("Escribe un numero entre 1 y 100");

            do
            {
                try
                {
                    miNumero = int.Parse(Console.ReadLine());//se itentara convertir el dato ingresado por el usuario a un numero.

                    if (miNumero > random) Console.WriteLine("El numero es mas bajo.");
                    if (miNumero < random) Console.WriteLine("El numero es mas alto.");
                    intentos++;

                }
                catch (FormatException fe)//captura el error si se ingresa texto
                {
                    Console.WriteLine($"Se ingreso texto. Vuelve a intentarlo con un valor valido. Tipo de error: {fe.Message}");
                    miNumero = 0;

                }
                catch (OverflowException oe)//captura el error si se ingresa un numero que sobrepasa el tipo int
                {
                    Console.WriteLine($"Se ingreso un numero demasiado grande. Vuelve a intentarlo con un valor valido. Tipo de error: {oe.Message}");
                    miNumero = 0;

                }
                catch (Exception ex)//captura cualquier otra excepcion no contemplada anteriormente.
                {
                    //Esta es una excepcion general, si la excepcion no esta contemplada con los catch anteriores quedará atrapada aquí.
                    //Se debe tener en cuenta que esta excepcion general debe ir de ultimo de todos los catch sino dara error pues el sistema vera que habran
                    //catch a los cuales el programa nunca alcanzara ya que todas las excepciones quedaran capturadas en el primer catch. Hay otra forma de lograr
                    //lo mismo que hemos hecho aca usando filtros, en el metodo EjemploDos se explica como.
                    Console.WriteLine($"Se produjo una excepcion del tipo {ex.Message}");
                    miNumero = 0;
                }

            } while (random != miNumero);

            Console.WriteLine($"Enhorabuena! Haz necesitado {intentos} intentos para lograrlo.");
        }

        static void EjemploDos()
        {
            //PROGRAMA: ADIVINAR EL NUMERO
            int intentos = 0;
            int miNumero;
            Random numeroRandom = new Random();
            int random = numeroRandom.Next(1, 100);//genera un numero random entre 1 y 100

            Console.WriteLine("Escribe un numero entre 1 y 100");

            do
            {
                try
                {
                    miNumero = int.Parse(Console.ReadLine());//se itentara convertir el dato ingresado por el usuario a un numero.

                    if (miNumero > random) Console.WriteLine("El numero es mas bajo.");
                    if (miNumero < random) Console.WriteLine("El numero es mas alto.");
                    intentos++;

                }
                //Excepciones con filtro: Indicamos que capture todas las excepciones cuando el tipo de excepcion sea DIFERENTE al tipo FormatException y
                //al tipo OverFlowException.

                //Estos filtros son útiles si se quiere dar a una excepcion un tratamiento personalizado.
                catch (Exception ex) when (ex.GetType() != typeof(FormatException) && ex.GetType() != typeof(OverflowException)) 
                {
                    Console.WriteLine($"Se produjo una excepcion del tipo {ex.Message}");
                    miNumero = 0;

                }catch(FormatException fe)
                {
                    Console.WriteLine($"Se ingreso texto. Vuelve a intentarlo con un valor valido. Tipo de error: {fe.Message}");
                    miNumero = 0;
                }
                catch(OverflowException oe)
                {
                    Console.WriteLine($"Se ingreso un numero demasiado grande. Vuelve a intentarlo con un valor valido. Tipo de error: {oe.Message}");
                    miNumero = 0;
                }

            } while (random != miNumero);

            Console.WriteLine($"Enhorabuena! Haz necesitado {intentos} intentos para lograrlo.");
        }

        static void EjemploTres()
        {
            /*
             Existe un comportamiento un tanto extraño en c# cuando se trabaja
            con numeros. Por ejemplo, si capturamos el valor mas alto que 
            un tipo de valor int y luego a ese valor le sumamos cualquier 
            numero mayor a uno se esperaría que el compilador mostrara un 
            error de desbordamiento, pero para sorpresa no pasa nada y el 
            programa continua con la ejecución, ahora bien la respuesta 
            que aparece en consola no es la esperada y por tanto errónea. Este 
            fenómeno ocurre por cuestion de rendimiento. En este caso el 
            compilador lo que hace es reiniciar el conteo de tal modo que al 
            sumar uno como el valor se desborda entonces el compilador pasa
            la variable a su valor minimo que en este caso es -2147483648
            si se le suma dos entonces el numero incrementa a -214748364, y
            así sucesivamente. Con esto no se detiene la ejecucion del programa 
            y continua.
            
            Ahora bien, muchas veces no es ese el comportamiento que 
            deseamos, para ello podemos usar la siguiente instrucción:

            checked
            {
                //codigo
            }

            o tambien:
            
            checked( //expresion especifica a evaluar );

            Esta instrucción comprueba los desbordamientos aritméticos y
            muestra una excepción en tiempo de ejecución. Cabe aclarar que
            esta comprobación solo funciona con tipos int y long.

            Existe una manera de activar esta opcion de manera global en
            todo el proyecto para que no debamos programar esta funcion:

            click derecho en el proyecto > propiedades > compilacion >
            avanzadas > marcar la casilla Comprobar el desbordamiento aritmetico y
            y subdesbordamiento

            Cuando las comprobaciones de desbordamiento estan activadas de
            manera global se puede hacer el proceso inverso, es decir, desactivar
            las comprobaciones de desbordamiento en tiempo de ejecución. Para ello
            se usa la instruccion:

            unchecked
            {
                //codigo
            }

            o tambien:
            
            unchecked( //expresion especifica a evaluar );
             */

            int minNumero = int.MinValue;//devuel el tipo primitivo mas bajo
            int maxNumero = int.MaxValue;//devuelve el tipo primitivo mas alto
            int resul;

            //resul = checked(maxNumero + 30);

            checked
            {
                resul = maxNumero + 2; //lanzara una excepcion overflow
            }
            Console.WriteLine(minNumero);
            Console.WriteLine(maxNumero);
            Console.WriteLine(resul);
        }
    }
}
