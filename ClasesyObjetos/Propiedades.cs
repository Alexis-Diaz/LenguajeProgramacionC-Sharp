using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesyObjetos
{
    //Las clases pueden tener campos, propiedades y métodos.

    //Una propiedad es un miembro de la clase que proporciona
    //un mecanismo flexible para leer, escribir o calcular el
    //valor de UN CAMPO PRIVADO.
    //Estas propiedades usan descriptores de acceso, o que es lo
    //mismo, métodos de acceso; get y set.
    //Estos descriptores permiten tener mayor control sobre la escritura
    //y lectura del valor de la propiedad.

    class FormaGeometrica
    {

        //PROPIEDADES AUTOIMPLEMENTADAS O ABREVIADAS
        //Esta es una propiedad con su respectivo get y set
        //escritos de forma abreviada, su tipo de acceso es
        //público, lo que indica que puede ser accedido desde
        //fuera de la clase por medio de la instancia.
        //Estas propiedades son utilizadas cuando no se requiere
        //ninguna lógica adicional en los descriptores de acceso 
        //de la propiedad. Esto permite al cliente que utiliza la clase
        //crear objetos a su antojo. Como punto importante,
        //se debe tener en cuenta que en estos casos es el COMPILADOR
        //el que CREA automáticamente los respectivos CAMPOS de
        //respaldo privado y anónimos a los que solo los descriptores
        //get y set pueden acceder. Ejemplo:
        public string NombreForma { get; set; }


        //PROPIEDADES CON CAMPOS DE RESPALDO EXPLÍCITOS
        //Esta es una propiedad con su respectivo get y set
        //escrito de forma completa. Esta forma es usada cuando
        //se desea implementar una lógica antes de devolver(get) o
        //escribir(set) el valor del campo privado.

        //Para escibir este tipo de propiedades, primero se 
        //debe tener un campo de respaldo privado.
        private int _cantidad;

        //Luego escribimos la propiedad con acceso público. Ahora
        //dentro de las llaves escribimos explícitamente a que
        //campo se accederá con los métodos de lectura y escritura
        //get y set. En este caso indicamos que con la propiedad
        //Edad podremos leer (get/obtener) y escribir (set/establecer)
        //el campo privado _Edad.
        public int Cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                _cantidad = value;
            }
        }



        //Si a la propiedad le quitamos el metodo get, significa que
        //solo será de escritura. En este caso, debemos hacer uso de 
        //un campo privado al cual le estableceremos el valor.
        private double _base;
        public double Base { set { _base = value; } }

        
        private double _altura;
        public double Altura { set { _altura = value; } }


        //Si a la propiedad le quitamos el set, siginifica que solo
        //será de lectura. En este caso no es necesario usar un
        //campo privado ya que debemos retornar de una vez el valor.
        public double Area { get { return _base * _altura; } }

    }
}
