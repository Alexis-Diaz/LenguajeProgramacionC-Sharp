//NET 7
// See https://aka.ms/new-console-template for more information

using Pilas;

NavegadorWeb navegador = new();

navegador.VisitarPagina("www.ejemplo.com/pagina1");
navegador.VisitarPagina("www.ejemplo.com/pagina2");
navegador.VisitarPagina("www.ejemplo.com/pagina3");

navegador.Retroceder();
navegador.Retroceder();
navegador.Retroceder();
navegador.Retroceder();

namespace Pilas
{
    class NavegadorWeb
    {
        private Stack<string> historial = new();

        public void VisitarPagina(string pagina)
        {
            Console.WriteLine($"Visitando página: {pagina}");
            historial.Push(pagina);
        }

        public void Retroceder()
        {
            if (historial.Count > 1)
            {
                historial.Pop(); // Elimina la página actual
                string paginaAnterior = historial.Peek(); // Obtiene la página anterior sin eliminarla
                Console.WriteLine($"Volviendo a la página anterior: {paginaAnterior}");
            }
            else
            {
                Console.WriteLine("No hay páginas para retroceder.");
            }
        }
    }
}
