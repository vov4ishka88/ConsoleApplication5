using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            Thread th1 = new Thread(new ThreadStart(obj1.printNumberOne));
            Thread th2 = new Thread(new ThreadStart(obj1.printNumberTwo));
            th1.Start();
            th2.Start();

        }
    }
}
