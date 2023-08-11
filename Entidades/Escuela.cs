using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Escuela : ObjetoEscuelaBase
    {
        public string País { get; set; }
        public string Ciudad { get; set; }
        public int AñoDeCreación { get; set; }
        public TiposEscuela TiposEscuela { get; set; }
        public List<Curso> Cursos { get; set; } = new List<Curso>();

        //Constructor con igualación por tuplas 
        public Escuela(string nombre, int añoDeCreación) => (Nombre, AñoDeCreación) = (nombre, añoDeCreación);

        public Escuela(string nombre, int año, TiposEscuela tipo, string pais = "", string cuidad = "")
        {
            (this.Nombre, this.AñoDeCreación) = (nombre, año);
            this.País = pais;
            this.Ciudad = cuidad;
        }
        public override string ToString()
        {
            return $"Nombre:{base.Nombre}, Tipo:{this.TiposEscuela}\nPaís:{this.País}, Ciudad:{this.Ciudad} ";
        }
    }
}
