using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        public string UniqueId { get; set; } = Guid.NewGuid().ToString();
        public string Nombre { get; set; }
        public string País { get; set; }
        public string Ciudad { get; set; }
        public int AñoDeCreación { get; set; }
        public TiposEscuela TiposEscuela { get; set; }
        public List<Curso> Cursos { get; set; }

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
            return $"Nombre:{this.Nombre}, Tipo:{this.TiposEscuela}\nPaís:{this.País}, Ciudad:{this.Ciudad} ";
        }
    }
}
