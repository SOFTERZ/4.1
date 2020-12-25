using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console4Ka
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] cumpotik = {-2, -1.5, -1, -0.5, 0, 0.5, 1, 1.5, 2, 2.5, 3, 3.5 };
            for (int i = 0; i < cumpotik.Length; i++)
                Console.WriteLine(cumpotik[i]);
         {     
            }
             double s;
             double[] kpytoi = {-1.5, -1, -0.5, 0, 0.5, 1, 1.5, 2, 2.5, 3}; 
             Console.WriteLine("Минимальное число");
             Console.WriteLine(cumpotik.Min());
             Console.WriteLine("Максимальное число");
             Console.WriteLine(cumpotik.Max());
             s = 10;
             Console.WriteLine("Кол-во чисел между мин. и макс. числами");
             Console.WriteLine(s);
            {
            }
            Console.ReadLine();
        }
    }
}
