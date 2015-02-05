using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication5
{
    class Class1
    {
        int a = 5;

        public void printNumberOne() {

            while (true) { 
                Console.WriteLine("1 : " + a);                
            Thread.Sleep(1000);
            a++;
            }
        }

        public void printNumberTwo() {

            while (true)
            {
                Console.WriteLine("2 : " + a);
                Thread.Sleep(1000);
                a++;
            }
        }
    }
}
