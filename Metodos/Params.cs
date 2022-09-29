using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Matematica
    {
        //PARAMS
        //Cuando necesitamos que un método sea capaz de recibir uno a más
        //parametros lo hacemos mediante la sobrecarga de métodos, pero
        //esto puede ser un inconveniente cuando no sabemos la cantidad
        //máxima de parametros a recibir.
        //Claro para solucionar este problema podemos hacer uso de otras
        //posibilidades, como por ejemplo, hacer uso de un único parámetro
        //pero de tipo lista o de tipo array.
        //Sin embargo existe otra manero de lograr la solución, y esta es 
        //indicándole al método que recibirá de uno a muchos parámetros.
        //La sixtaxi es la siguiente:
        public double Sumar (params double[] sumandos)   //La palabra reservada params le indica al
        {                                                //método que recibirá de uno a más parámetros.
            double total = 0;                            //
            foreach (double num in sumandos)             //Este toma todos los parámetros y los convierte
            {                                            //en un array de elementos del mismo tipo.
                total += num;                            //
            }                                            //Para acceder a su valor solo debemos iterar
            return total;                                //los elementos como cualquier otro array.
        }                                                
    }
}
