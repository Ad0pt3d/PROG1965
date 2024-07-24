using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the data source
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            // the query
            var myQuery = from obj in list
                          where obj > 2
                          select obj;

            // the execution
            foreach (var item in myQuery)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(" Now we show the Method Syntax");

            var myMethodSyntax = list.Where(obj => obj > 2);

            // execute the Method
            foreach (var item in myMethodSyntax)
            {
                Console.WriteLine(item);
            }

            // a mixed version of LINQ query
            var mixedSyntax = (from obj in list
                               select obj).Max();

            Console.WriteLine("Max value = " + mixedSyntax);
        }
    }
}
