using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAccesoI
{
    //PROTECTED INTERNAL
    //Los miembros de clase protected internal actúan
    //como internal dentro de su mismo ensamblado, pero
    //se convierten protected desde otro ensamblado.
    public class ClaseE
    {
        protected internal string CampoX;
    }
}
