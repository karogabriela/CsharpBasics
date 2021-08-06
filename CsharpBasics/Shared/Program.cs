using CsharpBasics.Delegates;
using CsharpBasics.AnonymousMethod;
using System;

namespace CsharpBasics.Shared
{
    class Program
    {
        static MyFirstDelegate myFirstDelegate = new MyFirstDelegate();
        static void Main(string[] args)
        {
            Console.WriteLine("\"Welcome to CsharpBasics project!!\"");

            //Calling a delegate using a target method.
            Console.WriteLine("\n\n¡¡Example calling a delegate from a target method!!");
            CallMyDelegateByTargetMethod();

            //Simple way of creating and calling a delegate.
            Console.WriteLine("\n\n¡¡Example calling a delegate!!");
            CallMyDelegate();

            //Calling a delegate by a lambda expression.
            Console.WriteLine("\n\n¡¡Example of using a delegate by a lambda expression!!");
            CallMyDelegateByLambda();

            //Printing a message using a delegate as a parameter.
            Console.WriteLine("\n\n¡¡Example using a delegate as a parameter!!");
            CallDelegateParameter();

            //splitting a number from an anononymous method
            Console.WriteLine("\n\n¡¡Example splitting a number from an anononymous method!!");
            GetSplitedNumber();

            //Handling events
            Console.WriteLine("\n\n¡¡Example handling events!");
            CallStartProcess();

            Console.ReadKey();
        }

        private static void CallMyDelegateByTargetMethod()
        {
            myFirstDelegate.CallMyDelegateByTargetMethod();
        }
        private static void CallMyDelegate()
        {
            myFirstDelegate.CallMyDelegate();
        }
        private static void CallMyDelegateByLambda()
        {
            myFirstDelegate.CallMyDelegateByLambda();
        }

        private static void CallDelegateParameter()
        {
            DelegateParameter delegateParameter = new DelegateParameter();
            delegateParameter.CallDelegateParameter();
        }

        private static void GetSplitedNumber()
        {
            MyFirstAnonymousMethod myFirstAnonymousMethod = new MyFirstAnonymousMethod();
            myFirstAnonymousMethod.GetSplitedNumber(99);
        }

        #region Delegates-Events
        private static void CallStartProcess()
        {
            HandlingEvents handlingEvents = new HandlingEvents();
            handlingEvents.ProcessCompleted += HE_ProcessCompleted;
            handlingEvents.StartProcess();
        }

        /// <summary>
        /// Event handler.
        /// </summary>
        /// <param name="sender">event source</param>
        /// <param name="e">event data</param>
        public static void HE_ProcessCompleted()
        {
            Console.WriteLine("Process completed");
        }
        #endregion
    }
}
