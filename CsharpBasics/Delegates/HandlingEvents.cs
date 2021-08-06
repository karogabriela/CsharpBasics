using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics.Delegates
{
    internal delegate void NotifyConsole();
    /// <summary>
    /// This class will show some simple examples about handling event with delegates.
    /// </summary>
    internal class HandlingEvents
    {
        internal event NotifyConsole ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process started");
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke();
        }
    }
}
