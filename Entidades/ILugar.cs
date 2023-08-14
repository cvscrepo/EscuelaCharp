using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa1.Entidades
{
    public interface ILugar
    {
        string Dirección { get; set; }   
        void LimpiarLugar();
    }
}
