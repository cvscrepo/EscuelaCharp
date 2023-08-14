// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using CoreEscuela.App;
using CoreEscuela.Entidades;
using CoreEscuela.Utils;
using Etapa1.Entidades;
using System;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("Bienvenidos a la escuela");
            //Printer.Beep(40, 500, 10);
            ImprimirAlumnosEscuela(engine.Escuela);
            ImpormirEvaluaciones(engine.Escuela);
            var listaObjetos = engine.GetObjetoEscuela();
            //ob = evaluacion;

            //Podemos usar la palabra clave is para preguntar si un objeto es de un tipo determinado
            //if(ob is Alumno)
            //{
            //    Alumno alumnoRecuperado = (Alumno)ob;
            //}
            //Tome este objeto como si fuera este obj, Si se puede hará devolverá el valor, de lo contrario dará null 
            //Alumno alumnoRecuperado2 = ob as Alumno;
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de escuela");

            foreach (var curso in escuela.Cursos)
            {
                Console.WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
            }
        }

        private static void ImprimirAlumnosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Alumnos en la escuela");

            foreach (var Curso in escuela.Cursos)
            {
                var alumnos = Curso.Alumnos;
                if (Curso.Alumnos.Count != 0)
                {
                    foreach (var alumno in alumnos)
                    {
                        Console.WriteLine(alumno.ToString());
                    }
                }
                else 
                {
                    Console.WriteLine("No hay datos");
                    break;
                }
            }
        }

        private static void ImprimirAsignaturasEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Asignaturas en la escuela por curso");

            foreach (var curso in escuela.Cursos)
            {
                Printer.WriteTitle(curso.ToString());
                foreach (var asignatura in curso.Asignaturas)
                {                 
                   Console.WriteLine(asignatura.ToString());                                   
                }
            }
        }
        private static void ImpormirEvaluaciones(Escuela escuela)
        {
            Printer.WriteTitle("Evaluaciones en la escuela por curso y asignatura");

            foreach (var curso in escuela.Cursos)
            {
                Printer.WriteTitle(curso.ToString());
                foreach (var alumno in curso.Alumnos)
                {
                    foreach (var evaluacion in alumno.Evaluaciones)
                    {
                        Console.WriteLine($"Nombre : {evaluacion.Nombre}, Alumno : {evaluacion.Alumno.Nombre}, Asignatura: {evaluacion.Asignatura.Nombre}, Nota : {evaluacion.Nota}");
                    }
                }
            }
        }



    }

       
}