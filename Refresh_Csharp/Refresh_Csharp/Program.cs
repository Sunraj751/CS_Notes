using System;
using System.Collections.Generic;
using System.Linq;

namespace Refresh_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program mp = new Program(); // instantiation of class in main
            mp.doSomething(); // calling a method inside the Program class 
            Console.ReadKey();
        }

        public void doSomething() // this is the method being called
        {
            Student me = new Student("jingle", "gyro");
            me.Hello();


        }
    }
}