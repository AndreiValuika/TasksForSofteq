using System;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            var wheels = Console.ReadLine().Split();
            int weelsOnCar = Convert.ToInt32(wheels[0]);
            int weels = Convert.ToInt32(wheels[1]);

            int[] weelsPoint = new int[weelsOnCar];

            for (int i = 0; i < weelsOnCar; i++)
            {
                weelsPoint[i] = Convert.ToInt32(Console.ReadLine());
            }

            double pointForOne = 0d;

            foreach (var item in weelsPoint)
            {
                pointForOne += 1d / item;
            }

            double kilometers = weels / pointForOne;
            Console.WriteLine(string.Format("{0:0.000}", kilometers));
        }
    }
}
