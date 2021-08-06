using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics.Delegates
{
    internal delegate void Del(string name);

    /// <summary>
    /// This class represents a example of calling a delegate as a parameter.
    /// </summary>
    internal class DelegateParameter
    {
        internal void CallDelegateParameter()
        {
            Del handler = DelegateMethod;
            PrintMessageUsingDelegateParamenter("Alligator", handler);
        }
        private void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        private void PrintMessageUsingDelegateParamenter(string name, Del delCallback)
        {
           delCallback($"Hello: {name}, Have a good day!");
        }
    }
}
