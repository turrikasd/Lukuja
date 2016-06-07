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
            List<float> numbers = new List<float>();
            bool quit = false;

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
                    numbers.Add(input);
                }
            }

            float total = 0.0f;
            for (int i = 0; i < numbers.Count; i++)
            {
                total += numbers[i];
            }

            float avg = total / numbers.Count;
            avg = (float)Math.Round(avg, 2);

            Console.WriteLine(avg);
            Console.ReadKey();
        }
    }
}
