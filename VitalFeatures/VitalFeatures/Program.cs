using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateMe delegateme = new DelegateMe();
            delegateme.BindMethodToDelegate();
            Console.ReadLine();
        } 
    }
}
