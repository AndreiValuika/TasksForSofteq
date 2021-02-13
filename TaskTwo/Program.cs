using System;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            var inputWheels = Console.ReadLine().Split();
            int wheelsOnCar = Convert.ToInt32(inputWheels[0]);
            int wheels = Convert.ToInt32(inputWheels[1]);

            int[] wheelsPoint = new int[wheelsOnCar];

            for (int i = 0; i < wheelsOnCar; i++)
            {
                wheelsPoint[i] = Convert.ToInt32(Console.ReadLine());
            }

            float pointForOne = 0f;

            // pointForOne shows how many "strength points" cars wheels lost for one kilometr.
            foreach (var item in wheelsPoint)
            {
                pointForOne += 1f / item;
            }

            float kilometers = wheels / pointForOne;
            Console.WriteLine();
            Console.WriteLine(string.Format("{0:0.000}", kilometers));
        }
    }
}
