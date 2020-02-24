using System;

namespace Hangman_2._0
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = 0;
            string[] list = { "world", "moblie", "home", "pakistan" };
            Random num = new Random();
            int num1 = num.Next(0, 4);
            string mysteryword = list[num1];
            int ww = mysteryword.Length;
            char[] guess = new char[mysteryword.Length];
            int b = 0;
            int c = 0;
            //bool chkflg = true;
            Console.WriteLine();
            Console.WriteLine("*********  WELCOME TO HANGMAN GAME  *************");
            Console.WriteLine();
            Console.WriteLine();
            design(a);
            Console.WriteLine();
            Console.WriteLine("______________________________________________");
            Console.WriteLine();
            Console.WriteLine("INTRUCTIONS:");
            Console.WriteLine();
            Console.WriteLine("-YOU HAVE 4 CHANCE TO GUESS THE WORD");
            Console.WriteLine("-Number of alphabets is " + ww);
            Console.WriteLine();

            for (int i = 0; i < ww; i++)
            
                guess[i] = '*';

            
            while (true)
            {
               
                Console.WriteLine();                
                char playerguess = Convert.ToChar(Console.ReadLine());
                String c1 = playerguess.ToString().ToLower();
                
                for (int i = 0; i < ww; ++i)
                    if (mysteryword[i] == playerguess)
                    {

                        guess[i] = playerguess;
                        ++c;  
                        
                        
                    }
                    else
                    {
                        ++b;
                        if(b==ww)
                        {
                            ++a;
                            design(a);
                            Console.WriteLine(" WRONG ANSWER ");
                            
                        }
                        
                    }
                b = 0;


                if (a == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("You have 3 last chance");
                    Console.WriteLine();
                }
                if (a == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("You have 2 last chance");
                    Console.WriteLine();
                }
                if (a == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("You have last chance");
                    Console.WriteLine();
                }
                if (a == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("YOU LOSE!!!!!!");
                    break;
                }
                if (c == ww)
                {
                    Console.WriteLine();
                    Console.WriteLine(guess);
                    Console.WriteLine("You Won!!!");
                    break;
                }
                Console.WriteLine(guess);
            }
                
        }


        public static void design(int a)
        {
            if (a == 0)
            {
                Console.WriteLine("\t\t|");
                Console.WriteLine("\t\t|");

                Console.WriteLine("\t _______|_______");
                Console.WriteLine("\t |             |");
                Console.WriteLine("\t |             |");
                Console.WriteLine("\t |             |");
                Console.WriteLine("\t |             |");
                Console.WriteLine("\t |_____________|");

                Console.WriteLine("\t\t|");
                Console.WriteLine("\t\t|");
                Console.WriteLine("\t\t|");
                Console.WriteLine("     ___________|___________");

                Console.WriteLine("\t\t|");
                Console.WriteLine("\t\t|");
                Console.WriteLine("\t\t|");
                Console.WriteLine("\t\t|");
            }
            if (a == 1)
            {

                Console.WriteLine("\t\t|");
                Console.WriteLine("\t\t|");

                Console.WriteLine("\t _______|_______");
                Console.WriteLine("\t |             |");
                Console.WriteLine("\t |             |");
                Console.WriteLine("\t |             |");
                Console.WriteLine("\t |             |");
                Console.WriteLine("\t |_____________|");

                Console.WriteLine("\t\t|");
                Console.WriteLine("\t\t|");
                Console.WriteLine("\t\t|");
                Console.WriteLine("     ___________|___________");
            }
            if (a == 2)
            {
                Console.WriteLine("\t\t|");
                Console.WriteLine("\t\t|");

                Console.WriteLine("\t _______|_______");
                Console.WriteLine("\t |             |");
                Console.WriteLine("\t |             |");
                Console.WriteLine("\t |             |");
                Console.WriteLine("\t |             |");
                Console.WriteLine("\t |_____________|");

            }
            if (a == 3)
            {
                Console.WriteLine("\t\t|");
                Console.WriteLine("\t\t|");
            }
            else
            {
                Console.WriteLine();
            }
        }

    }

}

