using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IronPython.Hosting;

namespace CSharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World From C#");
            var py = Python.CreateEngine();
            try
            {
                py.Execute("print('Hello World From Python')");
            }
            catch
            {
                Console.WriteLine("Wups!");
            }

            Console.ReadLine();
        }
    }
}
