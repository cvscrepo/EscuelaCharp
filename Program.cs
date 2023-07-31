// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using CoreEscuela.App;
using CoreEscuela.Entidades;
using CoreEscuela.Utils;
using System;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.EscribirTitulo("Bienvenidos a la escuela");
            Printer.Beep(2000, 500, 10);
            ImprimirCursosEscuela(engine.Escuela);

        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.EscribirTitulo("Cursos de escuela");

            foreach (var curso in escuela.Cursos)
            {
                Console.WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
            }
        }


    }

       
}