using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics.Delegates
{
    //Step 1 - Declare a delegate.
    internal delegate void MyDelegate(string name);
    
    /// <summary>
    /// Csharp use delegates to pass a function as a parameter.
    /// 
    /// To use a delegate you can follow the next three steps:
    ///     1. Declare a delegate.
    ///     2. Set a target method.
    ///     3. Invoke a delegate.
    ///     
    /// Delegate sintax
    /// [access modifier] delegate [return type][delegate name]([parameters])
    /// </summary>
    ///
    internal sealed class MyFirstDelegate
    {
        /// <summary>
        /// Calling a delegate using a target method.
        /// </summary>
        internal void CallMyDelegateByTargetMethod()
        {
            //Step 2 - Set a target method.
            MyDelegate myDelegate = new MyDelegate(SayHelloTo);
            //Step 3 - Invoke a delegate.
            myDelegate.Invoke("Loki");
        }

        /// <summary>
        /// Simple way of creating and calling a delegate.
        /// </summary>
        internal void CallMyDelegate()
        {
            MyDelegate myDelegate = SayHelloTo;
            myDelegate.Invoke("Silvie");
        }

        /// <summary>
        /// Calling a delegate by a lambda expression.
        /// </summary>
        internal void CallMyDelegateByLambda()
        {
            MyDelegate myDelegate = (string name) => Console.WriteLine($"Hello: {name}");
            myDelegate.Invoke("Mobius");
        }

        /// <summary>
        /// Target method.
        /// </summary>
        /// <param name="name">Name of someone.</param>
        private static void SayHelloTo(string name)
        {
            Console.WriteLine($"Hello: {name}");
        }
    }
}
