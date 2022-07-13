using System;
namespace Refresh_Csharp
{
    public class Teacher : User
    {
        public override void Hello()
        {
            Console.WriteLine("Teacher" + FullName);

        }
    }
}
