using System;
namespace Refresh_Csharp
{
    public  class User
    {
        public bool Verified { get; set; } = false;
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void Hello()
        {
            Console.WriteLine("Hi" + FullName);
        }

    }
}
