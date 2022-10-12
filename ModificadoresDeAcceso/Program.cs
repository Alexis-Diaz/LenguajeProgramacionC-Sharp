using System;

namespace ModificadoresDeAcceso
{
    // MODIFICADORES DE ACCESO
    // Los modificadores de acceso son palabras claves
    // que se usan para especificar la accesibilidad
    // declarada de un miembro o tipo.
    // 
    // USOS
    // No se permiten modificadores de acceso para los namespace, pues
    // estos no requieren ninguna restricción.
    //
    // Solo se permite un modificador de acceso para un miembro o tipo
    // excepto cuando se usa protected internal o private protected.
    //
    // Los tipos de nivel superior, que no estan anidados en otros tipos,
    // solo pueden tener una accesibilidad: internal o public. La accesibilidad
    // predeterminada para estos tipos es internal.
    //
    // Los tipos anidados, que son miembros de otros tipos, pueden tener 
    // accesibilidades declaradas como se indica a continuación:
    // 
    // |Existen 5 modificadores de acceso:        |Ordenados de menor a mayor restricción:
    // |public                                    |public
    // |protected                                 |internal
    // |internal                                  |protected
    // |private                                   |private
    // |file                                      |
    //
    //
    // Se pueden especificar 7 niveles de accesibilidad:
    //
    // public: el acceso no está restringido.
    // 
    // internal: el acceso está límitado al ensamblado actual.
    //
    // protected: el acceso está limitado a la clase contenedora
    //            o a los tipos derivados de la clase contendora.
    // 
    // private : el acceso está limitado a la clase contenedora o
    //           o a los tipos.
    //
    // protected internal: El acceso está limitado al ensamblado
    //                     actual o a los tipos derivados de la
    //                     clase contenedora.
    // 
    // private protected: el acceso está limitado a la clase con-
    //                    tenedora o a los tipos derivados de la
    //                    clase contenedora que hay en el ensam-
    //                    blado actual.
    // 
    // file: el tipo declarado solo es visible en el archivo de
    //       origen actual. Los tipos con ámbito de archivo se 
    //       usan generalmente para los generadores de origen.
    // 
    // 
    // EXPLICACIÓN DE USO
    //
    // PUBLIC
    // A continuación, se declaran dos clases, ClaseA que se encuentra en este
    // ensamblado y ClaseA ubicada en el ensamblado ModificadoresDeAccesoI.
    // Observar que se obtiene acceso a CampoX y CampoY de ambas clases desde
    // la clase PruebaAcceso1

    public class ClaseA
    {
        public string CampoX;
        public string CampoY;
    }

    class PruebaAcceso1
    {
        public void MetodoA()
        {
            //Se instancia la ClaseA de este ensamblado y se accede
            //directamente a sus miembros públicos.
            ClaseA claseA = new ClaseA();
            claseA.CampoX = "contenidoX";
            claseA.CampoY = "contenidoY";

            //Se instancia la ClaseA del ensamblado ModificadoresDeAccesoI y se accede
            //directamente a sus miembros públicos.
            ModificadoresDeAccesoI.ClaseA _claseA = new ModificadoresDeAccesoI.ClaseA();
            _claseA.CampoX = "contenidoX";
            _claseA.CampoY = "contenidoY";
        }
    }


    // INTERNAL
    //Este ejemplo muestra la creación de una clase llamada ClaseB de accesibilidad internal
    //ubicada en otro ensamblado ModificadoresDeAccesoI (o también biblioteca de clase o proyecto)
    //y una clase llamada PruebaAcceso que se encuentra en este mismo ensamblado. Esta segunda
    //clase trata de instanciar la ClaseB pero veamos lo que sucede.
    class PruebaAcceso2
    {
        void Metodo ()
        {
            //En este caso la instancia no es permitida pues la clase es internal.
            //Error CS0122: 'ClaseB' no es accesible debido a su nivel de protección.
            //ModificadoresDeAccesoI.ClaseB claseB = new ModificadoresDeAccesoI.ClaseB();
            //claseB.CampoX = "Algo de contenido";

            //En este caso la instancia si es permitida pues la clase es pública, pero
            //no se puede acceder a su campo porque es internal.
            //Error CS0122: 'ClaseB1.CampoX' no es accesible debido a su nivel de protección.
            ModificadoresDeAccesoI.ClaseB1 claseB1 = new ModificadoresDeAccesoI.ClaseB1();
            //claseB1.CampoX = "Algo de contenido";
        }
    }
    
    //PROTECTED
    //Una clase derivada intenta acceder al miembro protegido de la ClaseC
    //de este mismo ensamblado.
    class ClaseC
    {
        protected string CampoX;
    }

    class ClaseDerivadaA : ClaseC
    {
        void Metodo()
        {
            //Error CS1540: No se puede acceder al miembro protegido directamente de la 
            //instancia de la clase base llamada ClaseC.
            ClaseC claseC = new ClaseC();
            //claseC.CampoX = "Algo de contenido";

            //Estas son las dos formas de poder acceder al campo
            //protegido de la clase base.

            //Mediante la instancias de la clase derivada
            ClaseDerivadaA claseDerivada = new ClaseDerivadaA();
            claseDerivada.CampoX = "Algo de contenido";

            //o mediante la herencia con el uso de this.
            this.CampoX = "Algo de contenido";
        }
    }

    //Una clase derivada intenta acceder al miembro protegido de la ClaseC
    //de otro ensamblado.
    class ClaseDerivadaB : ModificadoresDeAccesoI.ClaseC
    {
        void Metodo()
        {
            //Error CS1540: No se puede acceder al miembro protegido directamente de la 
            //instancia de la clase base llamada ClaseC.
            ModificadoresDeAccesoI.ClaseC claseC = new ModificadoresDeAccesoI.ClaseC();
            //claseC.CampoX = "Algo de contenido";

            //Estas son las dos formas de poder acceder al campo
            //protegido de la clase base.

            //Mediante la instancias de la clase derivada
            ClaseDerivadaB claseDerivada = new ClaseDerivadaB();
            claseDerivada.CampoX = "Algo de contenido";

            //o mediante la herencia con el uso de this.
            this.CampoX = "Algo de contenido";
        }
    }

    class Program
    {
        static void Main()
        {

        }
    }
}
