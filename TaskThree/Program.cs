using System;

namespace TaskThree
{
    class Program
    {
        static int first;
        static int second;
        static int number;
        static int min;
        static int maxMult = 1;
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            first = Convert.ToInt32(input[0]);
            second = Convert.ToInt32(input[1]);
            number = Convert.ToInt32(input[2]);

            Step(number, 1);
            
            string outputMessage = (maxMult == 1) ? "0" : maxMult.ToString();
            Console.WriteLine(outputMessage);
        }

        static void Step(int n, int mult) 
        {
            if (n==0)
            {
                maxMult = mult > maxMult ? mult : maxMult;
                return;
            }

            if (n >= min)
            {
                Step(n - first, mult * first);
                Step(n - second, mult * second);
            }
        }
    }
}
