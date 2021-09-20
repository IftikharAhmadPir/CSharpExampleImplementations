using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    public class EventHandlingImplementation
    {
        public event EventHandler<bool> ProcessCompleted;

        public void StartProcessing()
        {
            OnProcessCompleted(true);
        }
        protected virtual void OnProcessCompleted(bool IsSuccessfull)
        {
           ProcessCompleted?.Invoke(this,IsSuccessfull);
        }
    }
}
