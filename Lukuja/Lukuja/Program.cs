using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lukuja
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            float avg = 0.0f;

            for (int i = 0; !quit; i++)
            {
                float input = 0.0f;
                string s = Console.ReadLine().Replace('.', ','); // Parse expects , instead of .
                input = float.Parse(s);

                if (input < 0.0f)
                    quit = true;
                else
                {
                    avg += input;

                    if (i != 0)
                        avg /= 2.0f;
                }
            }

            avg = (float)Math.Round(avg, 2);

            Console.WriteLine(avg);
            Console.ReadKey();
        }
    }
}
