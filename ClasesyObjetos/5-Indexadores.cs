using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesyObjetos
{
    class IndexadoresExperimentos
    {
        //Observación: no se puede crear dos o mas indexadores que
        //a traves de la instancia reciba el mismo tipo de parámetro.

        private List<int> _listaNumerosI;
        private List<int> _listaNumerosII;


        public IndexadoresExperimentos(List<int> listaNumerosA, List<int> listaNumerosB, List<string> listaString)
        {
            _listaNumerosI = listaNumerosA;
            _listaNumerosII = listaNumerosB;
        }

        public int this[int i]
        {
            get { return _listaNumerosI[i]; }
            set { _listaNumerosI[i] = value; }
        }

        //Este marca error
        //public int this[int i]
        //{
        //    get { return _listaNumerosII[i]; }
        //    set { _listaNumerosII[i] = value; }
        //}
    }
}
