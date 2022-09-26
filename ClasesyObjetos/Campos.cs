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

    //Esta es la clase Campos
    class Campos
    {
        //CAMPOS
        //Este es un ejemplo de campo cuyo tipo de acceso es 
        //privado, lo que indica que no se puede acceder desde
        //fuera de la clase por medio de la instancia.
        private List<int> _Valores;

        //Este es un ejemplo de campo público. Esto indica que
        //se puede acceder o establecer su valor desde fuera de
        //la clase.
        public string Nombre;
    }
}
