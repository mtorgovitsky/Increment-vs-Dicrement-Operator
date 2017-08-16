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
            int var1 = 6;
            int var2 = 6;
            Console.WriteLine($"Var1 before: (var1) {var1}");
            Console.WriteLine($"Var1 after: (++var1) {++var1}");
            Console.WriteLine($"Var1 after and after: (var1) {var1}");
            Console.WriteLine($"Var2 before: (var2) {var2}");
            Console.WriteLine($"Var2 after: (var2++) {var2++}");
            Console.WriteLine($"Var2 after and after: (var2++) {var2}");
            Console.ReadKey();
        }
    }
}
