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
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.', h - 1) + "/\\" + new string('.', h - 1));
            int step = 2;
            string result = "";
            int number = 2;
            int dashes = h - 1;
            for (int height = h - 1; height >= 1; height--)
            {

                result += new string('.', height - 1);
                result += "/";

                if (height == dashes)
                {
                    result += new string('-', number);
                    dashes = dashes - step;
                    step++;
                }
                else
                {
                    result += new string('.', number);
                }


                result += "\\";
                result += new string('.', height - 1);
                number += 2;
                Console.WriteLine(result);
                result = "";
            }

            //Console.WriteLine("/" + new string('-', h - 1) + new string('-', h - 1) + "\\");
        }
    }
}
