using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    public class Buzzfizz
    {
        public string fizz;
        public string buzz;
        public string fizzbuzz;

        public Buzzfizz()
        {

        }

        public void GetFizzBuzz()
        {

            for (double i = 0; i <= 100; i++)

                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("fizzbuzz");

                }
                else if (i % 3 == 0)
                
                    Console.WriteLine("fizz");

                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");

                }
                else
                {
                    Console.WriteLine(i);

                }
        }
        
    }
}
