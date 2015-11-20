using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFake.Lib;

namespace TestFake
{
    class Program
    {
        static void Main(string[] args)
        {
            new Script(true).CheckIsAdmin();
            Console.WriteLine("hello world!");
        }
    }
}
