using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3, 5));
            Console.ReadLine();
        }
        static int Topla(int x , int y)
        {
            return x + y;
        }
    }
}
