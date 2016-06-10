using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|---------------------------------------------------------------------------|");
            Console.WriteLine("| This little program created to help you to decide what to do this morning |");
            Console.WriteLine("|---------------------------------------------------------------------------|");
            char c = Convert.ToChar("y");
            do {
                bool x = false;
                Console.WriteLine("Set number (1-3):"); 
                string imp = Console.ReadLine();
                decimal num1 = Convert.ToDecimal(imp);
                num1 /= 1;
                int num = Convert.ToInt32(num1);
                if (num == 1)
                {
                    Console.WriteLine("Go to the Work"); x = true;
                }
                else if (num == 2)
                {
                    Console.WriteLine("Go for a walk"); x = true;
                }
                else if (num == 3)
                {
                    Console.WriteLine("Code smth"); x = true;
                }
                else
                {
                    Console.WriteLine("Incorrect value. Please, enter again"); x = false;
                }
                if (x)
                {   bool y;
                    do
                    {   y = false;
                        Console.WriteLine("Let's try again? (y/n)");
                        c = Convert.ToChar(Console.ReadLine());
                        if ((c != (Convert.ToChar("y")) && (c != Convert.ToChar("n"))))
                            {
                            Console.WriteLine("Incorrect answer"); y = true;
                        }
                    } while (y);
                }
               } while (c == Convert.ToChar("y"));
            Console.WriteLine("Have a nice day! =D");
            Console.ReadKey();

        }
    }
}
