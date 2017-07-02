using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalFeatures
{

    public class DelegateMe
    {

        // Delegate without parameter without any return value
        Action action = null;

        Func<string> delegateReturns = null;


        public DelegateMe()
        {
            action = () => { ShowToConsole(); ShowToWindow(); };
            action += ShowToConsole;
            action += ShowToWindow;
        }


        public void BindMethodToDelegate()
        {
            action();
            delegateReturns = () => ReturnsToWindow();
            //delegateReturns();
            Console.WriteLine(delegateReturns());
        }

        private string ShowToWindow(string message)
        {
            Console.WriteLine($"ShowtoWindow method called.{message}");
            return $"You have entered {message} ";
        }
        private string ReturnsToWindow()
        {
            //Console.WriteLine($"ShowtoWindow method called.{message}");
            return $"You have returend from a delegate.";
        }
        private void ShowToWindow()
        {
            Console.WriteLine("ShowtoWindow method called.");
        }

        private void ShowToConsole()
        {
            Console.WriteLine("ShowToConsole Method called.");
        }
    }
}
