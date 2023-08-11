using CoreEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa1.Entidades 
{
    public class Evaluación
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public Asignatura Asignatura { get; set; }
        public Alumno Alumno { get; set; }
        public double Nota { get; set; }
        public Evaluación() => UniqueId = Guid.NewGuid().ToString();
    }
}
