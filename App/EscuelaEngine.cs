using CoreEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.App
{
    public class EscuelaEngine
    {
        

        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, pais: "Colombia", cuidad: "Bogotá");
            //Inicializar las propiedades que conforman la escuela
            CargarCursos();

            foreach (var curso in Escuela.Cursos)
            {
                var lista = CargarAlumnos();
                curso.Alumnos.AddRange(lista);

            }
            CargarAsignaturas();
            CargarEvaluaciones();

        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura {Name = "Matematicas"},
                    new Asignatura {Name = "Educación Física"},
                    new Asignatura {Name = "Castellano"},
                    new Asignatura {Name = "Ciencias Naturales"}
                };
                
                curso.Asignaturas.AddRange(listaAsignaturas);
            }
        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private IEnumerable<Alumno> CargarAlumnos()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
    
            // Lenguaje lenq, aquí estamos seleccionando las propiedades en cada array 
            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Name = $"{n1} {n2} {a1}" };
            return listaAlumnos;
        }

        private void CargarCursos()
        {
            //Esto es una collection 
            Escuela.Cursos = new List<Curso>() {
                new Curso(){Nombre = "101", Jornada= TiposJornada.Mañana},
                new Curso(){Nombre = "201", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "301", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "401", Jornada = TiposJornada.Tarde},
                new Curso(){Nombre = "501", Jornada = TiposJornada.Tarde},
                new Curso(){Nombre = "601", Jornada = TiposJornada.Tarde}
            };
        }
    }
}
