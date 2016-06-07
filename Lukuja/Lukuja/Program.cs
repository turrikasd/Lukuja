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
            bool first = true;

            while (!quit)
            {
                float input = 0.0f;
                string s = Console.ReadLine();
                s = s.Replace('.', ','); // Parse expects , instead of .
                input = float.Parse(s);

                if (input < 0.0f)
                    quit = true;
                else
                {
                    avg += input;

                    if (!first)
                        avg /= 2.0f;
                    else
                        first = false;
                }
            }

            avg = (float)Math.Round(avg, 2);

            Console.WriteLine(avg);
            Console.ReadKey();
        }
    }
}
