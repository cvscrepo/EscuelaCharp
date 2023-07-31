using CoreEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa1.Entidades 
{
    public class Evaluaciones
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public Asignatura Asignatura { get; set; }
        public Alumno Alumno { get; set; }
        public float Nota { get; set; }
        public Evaluaciones() => UniqueId = Guid.NewGuid().ToString();
    }
}
