using System;

namespace ModificadoresDeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Los que tienen protected solo son accesible desde
            //las herencias

        }

        class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            protected string VariableProtegida { get; set; }
            
        }

        class Profesor:Persona
        {
            public string Profesion { get; set; }
            public string Escuela { get; set; }

            public void metodoProfesor()
            {

            }
        }

        class Alumno : Persona
        {
            public string Grado { get; set; }
        }
    }
}
