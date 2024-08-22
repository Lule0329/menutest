using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteMenu1();
            WriteMenu();
        }

        static void WriteMenu()
        {
            int index = 0;

            if (Console.ReadKey().Key == ConsoleKey.UpArrow)
            {
                if (index == 0)
                {
                    index++;
                    WriteMenu3();
                }
                else if (index == 1)
                {
                    index++;
                    WriteMenu1();
                }
                else if (index == 2)
                {
                    WriteMenu2();
                }
            }
        }

        static void WriteMenu1()
        {
            Console.Clear();

            Console.WriteLine(">test1");
            Console.WriteLine(" test2");
            Console.WriteLine(" test3");

            WriteMenu();
        }

        static void WriteMenu2()
        {
            Console.Clear();
            
            Console.WriteLine(" test1");
            Console.WriteLine(">test2");
            Console.WriteLine(" test3");
            
            WriteMenu();
        }

        static void WriteMenu3()
        {
            Console.Clear();

            Console.WriteLine(" test1");
            Console.WriteLine(" test2");
            Console.WriteLine(">test3");

            WriteMenu();
        }
    }
}
