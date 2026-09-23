using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinosaal
{
    class Kinosaal
    {
        
        private static char[,] _kinosaal = new char[6, 11];


        public static void Anzeigen()
        {
            int dim1Length = _kinosaal.GetLength(0);
            int dim2length = _kinosaal.GetLength(1);
            

            for (int zeile = 0; zeile < dim1Length; zeile++)
            {
                for (int spalte = 0; spalte < dim2length; spalte++)
                {
                    if (spalte == 0)
                        Console.Write((zeile + 1) + " ");
                    else
                        Console.Write("[F]");
                }

                Console.WriteLine();         
            }
            Console.ReadLine();

        }

        public static bool Buchen (int zeile, int spalte)
        {
            throw new NotImplementedException();
        }

        public static bool Reservieren(int zeile, int spalte)
        { 
            throw new NotImplementedException(); 
        }

        public static bool Freigeben(int zeile, int spalte)
        {
            throw new NotImplementedException();
        }
    }
}
