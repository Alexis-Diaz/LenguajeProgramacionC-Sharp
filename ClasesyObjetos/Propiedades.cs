using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesyObjetos
{
    //Las clases pueden tener campos, propiedades y métodos
    //La diferencia estre campo y propiedad, es que las 
    //propiedades tienen métodos de acceso, get y set.
    //Estos métodos permiten tener mayor control sobre la escritura
    //y lectura del valor de la propiedad.

    //Esta es la clase Propiedades
    class Propiedades
    {
        //PROPIEDADES ABREVIADAS
        //Esta es una propiedad con su respectivo get y set
        //escritos de forma abreviada, su tipo de acceso es
        //publico, lo que indica que puede ser accedido desde
        //fuera de la clase por medio de la instancia.
        public string NombrePersona { get; set; }


        //PROPIEDADES COMPLETAS
        //Esta es una propiedad con su respectivo get y set
        //escrito de forma completa. Esta forma es usada cuando
        //se desea implementar una lógica al momento de leer o
        //escribir el valor del campo privado.

        //Para escibir este tipo de propiedades, primero se 
        //debe tener un campo privado.
        private int _Edad;

        //Luego escribimos la propiedad con acceso público. Ahora
        //dentro de las llaves escribimos explícitamente a que
        //campo se accederá con los métodos de lectura y escritura
        //get y set. En este caso indicamos que con la propiedad
        //Edad podremos leer (get/obtener) y escribir (set/establecer)
        //el campo privado _Edad.
        public int Edad
        {
            get
            {
                return _Edad;
            }
            set
            {
                _Edad = value;
            }
        }
    }
}
