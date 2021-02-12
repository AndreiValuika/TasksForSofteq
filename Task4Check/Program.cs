using System;

namespace Task4Check
{
    class Program
    {
        const char BLACK = '1';
        const char WHITE = '0';
        static int action=0;
        static int ashift = 0;
        static int ajump = 0;

        static void Main(string[] args)
        {
            do
            {
                int whiteMouse = Convert.ToInt32(Console.ReadLine());
                int blackMouse = Convert.ToInt32(Console.ReadLine());
                
                var startMouses = CreateMouseArray(whiteMouse, blackMouse,WHITE,BLACK);
                var expectMouses = CreateMouseArray(blackMouse, whiteMouse,BLACK,WHITE);
              
               
                bool isWhite=true;
              
               
                while (!Eque(startMouses, expectMouses))
                {
                    Shift(isWhite, startMouses);
                    Jump(!isWhite, startMouses);
                    isWhite = !isWhite;
                }
                Console.WriteLine();
                Console.WriteLine("\nThe EnD " + action + "  aJump = " + ajump + "  aShift = " + ashift); 
                action = 0;
                ashift = 0;
                ajump = 0;
            }
            
            while (Console.ReadKey(true).Key == ConsoleKey.Enter);
        }
       
        static bool Eque(char[] a, char[] b) 
        {
            for (int i = 0; i < a.Length-1; i++)
            {
                if (a[i]!=b[i])
                {
                    return false;
                }
            }
            return true;
        }
        static char[] Jump(bool color, char[] vs) 
        {
           
            if (color)
            {
                for (int i = vs.Length - 1; i >= 2; i--)
                {
                    if (vs[i] == '_' && vs[i - 1] == BLACK && vs[i - 2] == WHITE)
                    {
                        Print(vs,"jump White");
                        vs[i] = WHITE;
                        vs[i - 2] = '_';
                        action++;
                        ajump++;
                    }
                }
                return vs;
            }
            for (int i = 2; i <= vs.Length-1; i++)
            {
                
                if (vs[i] == BLACK && vs[i - 1] == WHITE && vs[i - 2] == '_') 
                {
                    Print(vs, "jump Black");
                    vs[i] = '_';
                    vs[i - 2] = BLACK;
                    action++;
                    ajump++;
                }
            }
            return vs;
        } 
        static char[] Shift(bool color, char[] vs) 
        {
           
            if (color)
            {
                for (int i = 0; i < vs.Length-1; i++)
                {
                    if (vs[i] == WHITE && vs[i + 1] == '_')
                    {
                        Print(vs,"shift White");
                        vs[i] = '_';
                        vs[i + 1] = WHITE;
                        action++;
                        ashift++;
                        return vs;
                    }
                }
                return vs;
            }
            for (int i = vs.Length-1; i > 0; i--)
            {
                if (vs[i] == BLACK && vs[i - 1] == '_')
                {
                    Print(vs, "shift Black");
                    vs[i] = '_';
                    vs[i - 1] = BLACK;
                    

                    action++;
                    ashift++;
                    return vs;
                }
            }
            return vs;
        }

        static void Print(char[] a, string action)
        {
            Console.WriteLine();
            foreach (var item in a)
            {
                Console.Write(item+" ");
            }
            Console.Write("  action = " + action);
        }
        static char[] CreateMouseArray(int white, int black,char W,char B) 
        {
            char[] mouses = new char[black + white + 1]; 
            for (int i = 0; i < white; i++)
                mouses[i] = W;
            mouses[white] = '_';
            for (int i = white + 1; i < mouses.Length; i++)
                mouses[i] = B;
            return mouses;
        }
    }
}
