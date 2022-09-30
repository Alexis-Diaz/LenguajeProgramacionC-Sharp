using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesyObjetos
{
    //Las clases son los tipos mas fundamentales de C#. Una clase es una
    //estructura de datos que combina estados (campos) y acciones (metodos)
    //en una sola unidad. Una clase proporciona una definicion para instancias
    //de la clase, tambien conocidas como objetos.
    //Dicho de forma simple las clases son maquetas o plantillas que nos permiten
    //crear objetos diferentes que comparten las mismas propiedades y métodos.

    //Para crear una clase se usa la palabra reservada class
    //y un identificador o nombre para la clase.

    //Ejemplo:
    class Clases
    {
        //Aqui se escribe el cuerpo de la clase
    }

    //Las clases pueden ser de dos tipos
    //
    //CLASES INSTANCIABLES
    //Son clases que por su naturaleza, es necesario que mantenga
    //un estado diferente. Por lo que es necesario crear instancias
    //u objetos de la clase. Esta clases aunque se puedan instanciar
    //pueden combinar miembros de instancia (campos y métodos) y
    //miembros estáticos (campos y métodos), así como hacer el llamado
    //a un miembro de una clase estática.
    //
    //Ejemplo:
    public class ClaseInstanciable
    {
        //Campo de instacia
        private string CampoDeInstancia;

        //Método de instancia
        public void MetodoDeInstancia()
        {
            //Se invoca un metodo estático
            ClaseEstatica.MetodoEstatico();

        }

        //Campo estático
        private static string CampoEstatico;
        
        //Método estático
        public static void MetodoEstatico()
        {

        }
    }

    //CLASES ESTÁTICAS
    //Son clases que no necesitan tener un estado por lo que no
    //es necesario crear instancias u objetos de la clase. Como
    //detalle dentro de estas clases no se pueden crear instancias (objetos)
    //ni miembros de instancias ( campos y métodos ). Hacerlo
    //mostrará un error en tiempo de compilación.
    public static class ClaseEstatica
    {
        //Campo estático
        private static string CampoEstatico;

        //Método estático
        public static void MetodoEstatico()
        {

        }
    }
}
