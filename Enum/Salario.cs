using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Salario
    {
        Bonus Antonio = Bonus.bueno;
       
        public void Imprimir()
        {
            //para visualizar en consola el el valor hacemos un
            //casting a double, esto obliga a mostrar el valor y
            //no la clave del enum.
            double BonusAnutonio = (double)Antonio;
            Console.WriteLine(BonusAnutonio);
        }
    }

    enum Bonus
    {
        //podemos agregar valores segun conveniencia
        bajo=500,
        normal=1000,
        bueno=1500,
        extra=3000
    }
}
