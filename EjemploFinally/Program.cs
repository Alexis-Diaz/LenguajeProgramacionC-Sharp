using System;
using System.IO;//Sirve para usar la clase StreamReader

namespace EjemploFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Para solicitar recursos de la maquina StreamReader
             habre un canal de comunicacion que se debe cerrar
             no consumir recursos de la maquina, esto es ideal 
             hacerlo en el bloque finally del try. Esto es cierto
             hacer uso de bases de datos.
             */


            //La clase StreamReader sirve para hacer lectura
            //y escritura de archivos del equipo.
            StreamReader archivo = null;

            try
            {
                string linea;
                int contador = 0;

                //para ver su funcionamiento es necesario
                //crear un block ne notas llamado libro
                //en el escritorio sino dara una excepcion
                //FileNotFoundException (archivo no encontrado)
                string path = @"C:\Users\DELL\Desktop\libro.txt";

                archivo = new StreamReader(path);

                //ReadLine() lee una linea, con el while leemos el 
                //archivo linea por linea, la última siempre devuelve null.
                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }

                //linea = archivo.ReadToEnd(); //ReadToEnd() parece que lee todo el archivo de golpe;
                //Console.WriteLine(linea);

            }
            catch (FileNotFoundException fnfe)
            {

                Console.WriteLine($"Error con la lectura. Exception: {fnfe.Message} tipo: {fnfe.GetType()}"); ;
            }
            finally
            {
                if (archivo != null) archivo.Close();
                Console.WriteLine("Conexion con el fichero cerrada.");
            }
        }
    }
}
