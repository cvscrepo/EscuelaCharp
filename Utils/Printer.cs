using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Utils
{
    //Las clases statics no permite crear nuevas instancias 
    //La clase funciona como un objeto, no pueden crear instancias pero se puede usar sus propiedades
    public static class Printer
    {
        public static void DibujarLinea(int tamaño = 10)
        {
            var linea = "".PadLeft(tamaño, '=');
            Console.WriteLine(linea);
        }

        public static void EscribirTitulo(string titulo)
        {
            DibujarLinea(titulo.Length);
            Console.WriteLine(titulo);
            DibujarLinea(titulo.Length); 
        }

        public static void Beep(int hz = 2000, int tiempo = 500, int cantidad =1) 
        {
            while (cantidad-- > 0)
            {
                Console.Beep(hz, tiempo);
            }
        }
    }
}
