using System;
using System.Collections.Generic;

namespace ClasesyObjetos
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Uso de los campos
            Console.WriteLine("Ejemplo de campos ejecutado");
            Llamada campos = new Llamada();
            campos.MiMetodo();
            Console.WriteLine(Environment.NewLine);



            //Uso de las propiedades
            Console.WriteLine("Ejemplo de propiedades ejecutado");
            FormaGeometrica cuadro = new FormaGeometrica();
            cuadro.NombreForma = "cuadrado";
            cuadro.Cantidad = 10;
            cuadro.Base = 56.3;
            cuadro.Altura = 10;

            Console.WriteLine(cuadro.NombreForma);
            Console.WriteLine(cuadro.Cantidad);
            Console.WriteLine(cuadro.Area);
            Console.WriteLine(Environment.NewLine);




            //Uso de indexadores
            Console.WriteLine("Ejemplo de indexadores ejecutado");
            LlamadaIndexadorII indexadoresII = new LlamadaIndexadorII();
            indexadoresII.MiMetodo();

            Console.Read();

        }
    }
}
