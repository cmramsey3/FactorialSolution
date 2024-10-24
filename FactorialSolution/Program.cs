using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactorialSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(9));
            Console.WriteLine(HasA("Lucas"));
        }
        /// <summary>
        /// Compute a factorial of an int
        /// </summary>
        /// <param name="num">The integer to use (non-negative)</param>
        /// <returns>The factorial of num</returns>
        static int Factorial(int num)
        {
            int factorial = 1;
            int counter = 1;
            while (counter <= num)
            {
                factorial *= counter;
                counter = counter + 1;
            }
            return factorial;
        }
        /// <summary>
        /// Check to see if a string has an A in it
        /// </summary>
        /// <param name="pw">String to check</param>
        /// <returns>True if String has A in it False if not</returns>
        static bool HasA(string pw)
        {
            if (pw.ToUpper().Contains("A"))
                return true;
            else
                return false;
        }
    }
}
