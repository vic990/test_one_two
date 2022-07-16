using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaNumeroUno
{
    class pruebaDos
    {
       public void contar(string oracion) {
            int a = 0;
            int e = 0;
            int i = 0;
            int o = 0;
            int u = 0;
            oracion.ToLower();
            for (int j =0; j < oracion.Length; j++)
            {
                string letra = oracion[j].ToString();
                switch (letra)
                {
                    case "a":
                        a += 1;
                        break;
                    case "e":
                        e += 1;
                        break;
                    case "i":
                        i += 1;
                        break;
                    case "o":
                        o += 1;
                        break;
                    case "u":
                        u += 1;
                        break;
                }

            }

            Console.WriteLine("Cantidad de letras a " + a);
            Console.WriteLine("Cantidad de letras e " + e);
            Console.WriteLine("Cantidad de letras i " + i);
            Console.WriteLine("Cantidad de letras o " + o);
            Console.WriteLine("Cantidad de letras u " + u);
        }
    }
}
