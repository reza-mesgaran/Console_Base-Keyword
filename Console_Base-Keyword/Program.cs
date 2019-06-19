using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//  --base keyword-- : 2st Usage : specify which method (baseclass's method or derived class'method) called when revoke a virtual-override method

namespace Console_Base_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.mymethod();         
            
            Console.ReadKey();
        }
    }

    class BaseClass
    {
        public virtual void mymethod()
        {
            Console.WriteLine("I am a virtual method of base class");
            
            
        }

    }
    class DerivedClass : BaseClass
    {
        public override void mymethod()
        {
            Console.WriteLine("I am a override method of derived class");

            base.mymethod();     //  with --base-keyword-- we have access to virtual method of base class inside the override method of derived class
        }
       
    }
}
