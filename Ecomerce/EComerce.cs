using System;

namespace ECommerce
{
    class Customer
    {
        
        protected int Id;
        protected string FirstName;
        protected string LastName;
        protected string Adress;
        protected int PostalCode;
        protected string Email;
        protected string Password;
        public int Age { get; set;}



        // Constructor
        public Customer(string firstName, string lastName, string email)
        {
            // Called on instantiation
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }
    

        // visibility - returned value - MethodName()
        public void Login()
        {
            Console.WriteLine($"Ciao {this.FirstName} {this.LastName}, you are logged in.");
        }
        public  static void List() 
        {
            Console.WriteLine("");
        }
        
        
    }

}