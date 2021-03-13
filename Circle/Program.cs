using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main()
        {
            string []circles_string = File.ReadAllText("../input.txt").Split('\n');
            foreach(string str in circles_string)
            {
                string []f = str.Split(' ');
                Circle temp = Circle.Valide(double.Parse(f[0]), double.Parse(f[1]), double.Parse(f[2]));
                Console.WriteLine(temp);
                Console.WriteLine(temp.S());
                Console.WriteLine(temp.L());
                Console.WriteLine();
            }

        }
    }
}
