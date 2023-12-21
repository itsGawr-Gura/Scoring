using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring
{
    public class Diamond
    {
        public static string Make(int size)
        {
            if (size <= 0 || size % 2 == 0)
                return null;

            string diamond = "";

            int mid = size / 2;

            for (int i = 0; i <= mid; i++)
            {
                int spaces = mid - i;
                diamond += new string(' ', spaces);
                diamond += new string('*', (i * 2) + 1);
                diamond += new string(' ', spaces);
                diamond += "\n";
            }

            for (int i = mid - 1; i >= 0; i--)
            {
                int spaces = mid - i;
                diamond += new string(' ', spaces);
                diamond += new string('*', (i * 2) + 1);
                diamond += new string(' ', spaces);
                diamond += "\n";
            }

            return diamond;
        }
    }
}
