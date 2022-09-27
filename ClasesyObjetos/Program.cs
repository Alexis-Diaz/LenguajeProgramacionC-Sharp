using System;
using System.Collections.Generic;

namespace ClasesyObjetos
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Uso de los campos


            //Uso de las propiedades
            FormaGeometrica cuadro = new FormaGeometrica();
            cuadro.NombreForma = "cuadrado";
            cuadro.Cantidad = 10;
            cuadro.Base = 56.3;
            cuadro.Altura = 10;

            Console.WriteLine(cuadro.NombreForma);
            Console.WriteLine(cuadro.Cantidad);
            Console.WriteLine(cuadro.Area);
            Console.Read();
        }
    }
}
