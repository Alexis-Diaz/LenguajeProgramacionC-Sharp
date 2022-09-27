using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesyObjetos
{
    class IndexadoresI
    {
        //INDEXADORES
        //Los indexadores permiten trabajar con vectores o listas
        //directamente desde la instancia de clase, pero un valor
        //a la vez, sin permitir obtener o escribir el valor a to-
        //da la lista completa.
        //
        //
        //Por ejemplo, normalmente haríamos los siguiente:
        //Declaramos el siguiente campo privado que al-
        //macena una lista de números.
        private List<int> _listaNumerica;

        //Y luego accederíamos a este campo privado desde una
        //propiedad, de la siguiente manera:
        //Nota: Esta es otra forma más reciente de escribir el get y set
        public List<int> ListaNumerica { get => _listaNumerica; set => _listaNumerica = value; }

        //O puede que preferiríamos utilizar la forma autoimplementada
        public List<int>ListaNumerica_ { get; set; }


        //Con lo anterior si instanciamos la clase Indexadores podremos leer
        //y escribir el valor del campo de respaldo privado _listaNumerica
        //sin nunguna restricción, de la siguiente manera:
    }

    class LlamadaIndexadorI
    {
        public void MiMetodo()
        {
            IndexadoresI indexadores = new IndexadoresI();

            //Escritura
            indexadores.ListaNumerica = new List<int>() { 1, 2, 3, 4 };

            //Lectura
            foreach (var item in indexadores.ListaNumerica)            
            {
                Console.WriteLine(item);
            }
        }
    }




    //Ahora supongamos que lo que en realidad deseamos es poder permitirle al
    //cliente inicializar el campo privado desde su constructor agregando una
    //lista completa, pero que después ya no pueda tener el control total de 
    //la lista, sino que solo pueda acceder a un elemento a la vez por me-
    //dio de la instancia. ¿Cómo se pudiera hacer eso?

    //Tenemos la siguiente clase
    class IndexadoresII
    {
        //Agregamos un campo de respaldo privado para restringir su acceso.
        private List<int> _listaNumerica;


        //Ahora en el constructor le indicamos al cliente que lo inicialice.
        public IndexadoresII(List<int> listaNumerica)
        {
            _listaNumerica = listaNumerica;
        }

        //Ahora en lugar de acceder al campo por medio de una propiedad, lo
        //haremos a traves de una propiedad especial indexador.
        //Su sintaxis es la siguiente:

        public int this[int i]               //Este método indexador recibe como parámetro un valor de tipo entero (entre corchetes).
        {                                    //
            get                              //Se usa this porque el parámetro será pasado directamente desde la instancia de clase.
            {                                //
                return _listaNumerica[i];    //En el método get se retorna solo el elemento que se encuentra en la posición i de la lista,
            }                                //es por esa razón que en la devolución se indica que retornará un valor int y no una lista.
            set                              //
            {                                //En el método set se reescribe el valor que se encuentra en la posición i de la lista.
                _listaNumerica[i] = value;   
            }                                
        }                                    
    }

    //Para poder ver su funcionamiento, crearemos una nueva clase
    class LlamadaIndexadorII
    {
        public void MiMetodo()
        {
            //Instanciamos la clase IndexadoresII e inicializamos su
            //campo a traves de su contructor
            IndexadoresII indexadoresII = new IndexadoresII(new List<int>() { 1, 2, 3, 4 });

            //Ahora trataremos de leer el valor de ese campo privado, notaremos que 
            //ahora es imposible leer todos sus valores ya que solo nos permite leer
            //uno por uno.

            //Para realizar la lectura, hacemos lo siguiente:
            
            Console.WriteLine(indexadoresII[0]);        //Como vemos por medio de la instancia pasamos un entero. Este valor
                                                        //representa la posicion del valor de la lista que deseamos retornar.

            //Para realizar la escritura, hacemos lo siguiente:
            indexadoresII[0] = 45;
            Console.WriteLine(indexadoresII[0]);
        }
    }
}
