using System;

namespace TasksForSofteq
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            
            int numberForTestCase = Convert.ToInt32(Console.ReadLine());
            double[] setOfEva = new double[numberForTestCase];
           
            for (int i = 0; i < numberForTestCase; i++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                setOfEva[i] = GetFunctionEva(x);
            }

            foreach (var evalation in setOfEva)
            {
                Console.WriteLine(string.Format("{0:0.000}", evalation));
            }
        }
        static double GetFunctionEva(double x) 
        {
            return Math.Pow(x, 4) + 1.2 * Math.Pow(x, 3) - 20 * Math.Pow(x, 2) + 123.456;
        }
    }
}
