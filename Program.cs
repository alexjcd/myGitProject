using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitLib_Al;

namespace MainApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassAlex classAlex = new ClassAlex();
            Console.ForegroundColor = ConsoleColor.Cyan;
           Console.WriteLine( classAlex.GetGreetings());
        }
    }
}
