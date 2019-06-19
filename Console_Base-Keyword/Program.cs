using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//  --base keyword-- : 1st Usage : specify which base-class's constructor called when creating instances of a derived class !

namespace Console_Base_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Instance of Base Class Created -----");
            baseClass baseClass = new baseClass();       //--> Only run baseClass's parameterless-Constructor  
            Console.WriteLine("-------Instance of Base Class Created -----");
            baseClass baseClass1 = new baseClass(1);     //--> Only run baseClass's parameterized-Constructor 
            Console.WriteLine("-------Instance of drived Class Created -----");
            derivedClass derivedClass = new derivedClass();   //--> run baseClass's parameterless-Constructor +  derivedClass's parameterless-Constructor
            Console.WriteLine("-------Instance of drived Class Created -----");
            derivedClass derivedClass1 = new derivedClass(1); //--> run baseClass's parameterized-Constructor +  derivedClass's parameterized-Constructor
            Console.WriteLine("-------Instance of drived Class based on base class Created -----");
            baseClass m = new derivedClass();  //--> run baseClass's parameterless-Constructor +  derivedClass's parameterless-Constructor
            Console.WriteLine("-------Instance of drived Class based on base class Created -----");
            baseClass m1 = new derivedClass(1); //--> run baseClass's parameterized-Constructor +  derivedClass's parameterized-Constructor
            Console.ReadKey();
        }
    }

    class baseClass
    {
        public baseClass()
        {
            Console.WriteLine("I am base class's constructor (parameterless) \n \n");
        }
        public baseClass(int i)
        {
            Console.WriteLine("I am base class's constructor (parameterized) : {0} \n \n",i);

        }
    }
    class derivedClass : baseClass
    {
        public derivedClass() :base()
        {
            Console.WriteLine("I am derived class's constructor (parameterless) \n \n");

        }
        public derivedClass(int i) :base(i)
        {
            Console.WriteLine("I am derived class's constructor (parameterized) : {0} \n \n", i);
        }
    }
}
