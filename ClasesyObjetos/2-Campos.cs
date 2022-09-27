using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesyObjetos
{
    //CAMPOS
    //Las clases pueden tener campos, propiedades y métodos
    //
    //Los CAMPOS son variables de cualquier tipo pero que se 
    //declaran directamente en una clase o struct.
    //Las clases pueden tener campos de instancias, estáticos
    //o ambos.
    //
    //Los campos generalmente deben ser privados y el cliente
    //debe acceder a este ya sea por medio de métodos, propiedades
    //o indizadores. Esto sirve para protegerse de las entradas
    //de datos no validados.
    //
    //Cuando un campo es accedido por medio de una propiedad,
    //entonces se le conoce como memoria auxiliar o campo de respaldo.

    class Campos
    {
        //CAMPOS DE INSTANCIA
        //Estos campos son especificos de una instancia de clase,
        //esto indica que pueden ser accedidos desde una instancia
        //y no desde el tipo de clase, para ello se debe de el nivel
        //de acceso publico. Estos campos no son recomendados.
        //Ejemplo:
        public List<int> ValoresA;


        //CAMPOS ESTÁTICO
        //Estos campos pertenecen al propio tipo y no a la instancia.
        //Esto significa que el valor almacenado en el campo, es el mismo
        //en todas las instancias. Si se trata de acceder a este campo por
        //medio de la instancia se obtendrá un error en tiempo de compliación.
        //Ejemplo:
        public static List<int> ValoresB;
    }

    class Llamada
    {
        public void MiMetodo()
        {
            //Campos de instancia
            Campos campos = new Campos();
            campos.ValoresA = new List<int>() { 1, 2, 3, 4 };

            //Campo estático
            Campos.ValoresB = new List<int>() { 1, 2, 4, 5};
        }
    }
}
