using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAccesoI
{
    //INTERNAL
    //Las clases de nivel superior (que no estan anidadas dentro de
    //otro tipo) pueden tener dos tipos de accesibilidad: internal o 
    //public. De forma predeterminada son internal. Esto significa que
    //solo es accesible desde este mismo ensamblado.
    internal class ClaseB
    {
        public string CampoX;
    }

    //Los miembros internal solo son accedidos desde este mismo
    //ensamblado.
    public class ClaseB1
    {
        internal string CampoX;
    }
}
