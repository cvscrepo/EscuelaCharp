using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }

        public Alumno() => UniqueId = Guid.NewGuid().ToString();
        
    }
}
