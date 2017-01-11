using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veikkaus
{
    public class Lotto
    {
        public static void DrawLotto()
        {
            int luku;
            int[] luvut = new int[41];

            Console.WriteLine("Arvotaan viikon oikeat lottorivit:");
            Random rnd = new Random();
            for (int i = 1; i < 41; i++)
            {
                luku = rnd.Next(1, 41);  // 1 <= month < 13
                luvut[i] = luku;

            }
        }
    }
}
