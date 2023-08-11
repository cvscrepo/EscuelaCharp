using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Curso : ObjetoEscuelaBase
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; } = new List<Asignatura>();
        public List<Alumno> Alumnos { get; set; } = new List<Alumno>();


        public Curso() => UniqueId = Guid.NewGuid().ToString();

        public override string ToString()
        {
            return $"Nombre del curso: {Nombre} Jornada: {Jornada}";
        }
    }
}
