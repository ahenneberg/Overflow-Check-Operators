using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow_Check_Operators
{
    class Program
    {
        static void Main()
        {
            // Arithmetic operations on integral types can cause overflow.
            // Overflow does not throw any exceptions, just results in "wrap-around"
            // Overflow example:
            int a = int.MinValue;
            a--;                                    // Causes Wrap-around 
            Console.WriteLine(a == int.MaxValue);   // True 
            /* Overflow check operators tells the runtime to create an OverFlowException
               rather than overflowing silently when an integral-type expression 
               exceeds the limits of that type. */
            /* The checked operator affects expressions with the ++, --, +, -, *, /
               and the explicit conversion operators between integral types*/
            int b = 1_000_000;
            int c = 1_000_000;
            int d = checked(b * c);                 // Checks just the expression.
            checked
            {// Checks all expressions in a statement block.
                d = b * c;
                d = b * b * c;
            }
        }
    }
}
