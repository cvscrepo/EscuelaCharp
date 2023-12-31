﻿using CoreEscuela.Entidades;
using CoreEscuela.Utils;
using Etapa1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.App
{
    public sealed class EscuelaEngine
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
            CargarAsignaturas();
            CargarEvaluaciones(Escuela);

        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura {Nombre = "Matematicas"},
                    new Asignatura {Nombre = "Educación Física"},
                    new Asignatura {Nombre = "Castellano"},
                    new Asignatura {Nombre = "Ciencias Naturales"}
                };

                curso.Asignaturas.AddRange(listaAsignaturas);
            }
        }

        private void CargarEvaluaciones(Escuela escuela, int cantidadEvaluaciones = 5)
        {                   
            foreach (var curso in escuela.Cursos)
            {
                Random rnd = new Random();
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        for (int i = 0; i < cantidadEvaluaciones; i++)
                        {
                            var evaluacion = new Evaluación()
                            {
                                Nombre = $"{asignatura.Nombre}",
                                Alumno = alumno,
                                Asignatura = asignatura,
                                Nota = Math.Round(rnd.NextDouble() * 5, 1)
                            };
                            alumno.Evaluaciones.Add(evaluacion);
                        }
                    }
                }
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
    
            // Lenguaje lenq, aquí estamos seleccionando las propiedades en cada array 
            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };
            return listaAlumnos.OrderBy((alumno)=> alumno.UniqueId).Take(cantidad).ToList();
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
            Random rnd = new Random();
            
            foreach (var curso in Escuela.Cursos)
            {
                int cantidadRamdom = rnd.Next(5, 20);
                curso.Alumnos = GenerarAlumnosAlAzar(cantidadRamdom);
            }
        }

        public List<ObjetoEscuelaBase> GetObjetoEscuela()
        {
            var listaObj = new List<ObjetoEscuelaBase>();
            listaObj.Add(Escuela);
            listaObj.AddRange(Escuela.Cursos);
            foreach (var curso in Escuela.Cursos)
            {
                listaObj.AddRange(curso.Asignaturas);
                listaObj.AddRange(curso.Alumnos);
                
                
                foreach (var alumno in curso.Alumnos)
                {
                    listaObj.AddRange(alumno.Evaluaciones);
                }
            }
            return listaObj;
        }
    }
}
