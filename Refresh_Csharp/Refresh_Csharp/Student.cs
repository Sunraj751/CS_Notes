using System;
namespace Refresh_Csharp
{
    public class Student : User, ITalk
    {
        public Student(string firstName, string lastName)
        {
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Console.WriteLine("hello");
        }

        public override void Hello()
        {
            Console.WriteLine("Hello running from student " + FullName);
        }
    }
}
