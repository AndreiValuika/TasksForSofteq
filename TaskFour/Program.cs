using System;

namespace TaskFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input mouses count in format : \'white black'");
            var mouses = Console.ReadLine().Split();
            int white = Convert.ToInt32(mouses[0]);
            int black = Convert.ToInt32(mouses[1]);

            //explanations and evidence see in ReadMe.txt 
            var actions = white * black + white + black;
            Console.WriteLine(actions);
        }
    }
}
