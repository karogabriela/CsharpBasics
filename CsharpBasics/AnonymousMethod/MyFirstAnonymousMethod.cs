using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics.AnonymousMethod
{
    internal delegate void SplitNumber(double number);

    /// <summary>
    /// Anonymous methods are deeply related to delegates.
    /// </summary>
    internal class MyFirstAnonymousMethod
    {
        /// <summary>
        /// Example of an anononymous method implementation.
        /// </summary>
        /// <param name="numberToSplit"></param>
        internal void GetSplitedNumber(double numberToSplit)
        {
            SplitNumber splitNumber = delegate (double number) {
                Console.WriteLine($"The original number is: {number} and the splited is: {number/2}");
            };
            splitNumber(numberToSplit);
        }
    }
}
