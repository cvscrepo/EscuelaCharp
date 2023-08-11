using Etapa1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Alumno : ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
        public Alumno() => UniqueId = Guid.NewGuid().ToString();

        public override string ToString()
        {
            return $"Id: {base.UniqueId} Name: {base.Nombre}"; 
        }
    }
}
