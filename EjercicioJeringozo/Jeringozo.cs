using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJeringozo
{
    internal class Jeringozo
    {

        public static string EncriptarTexto(string texto)
        {
            char[] vocales = {'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'u', 'ú' };            
            List<char> resultado = new List<char> ();

            foreach (char t in texto) 
            {
                resultado.Add (t); // siempre agrego la letra

                foreach (char v in vocales)
                {
                    if(t == v)
                    {
                        resultado.Add ('p'); // si la letra es vocal, agrego p
                        resultado.Add (t); // y luego la letra nuevamente
                    }
                }
            }
            
            return new string(resultado.ToArray());
        }
    }
}


