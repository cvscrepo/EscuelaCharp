using Etapa1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    //Una clase puede tener el modificador de acceso abstract, que lo convierte en idea, nadie puede crear instancia de una clase abstracta
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueId { get; set; } = Guid.NewGuid().ToString();
        public string Nombre { get; set; }

        public ObjetoEscuelaBase() 
        {
            UniqueId = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Nombre}, {UniqueId}";

        }

        
    }

}
