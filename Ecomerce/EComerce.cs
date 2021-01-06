//PROGRAM.CS ES
/*using ECommerce;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i].ToUpper());
            }

            // var firstCustomer = new Customer();
            Costomer firstCostomer = new Costomer("Romeo", "Colosseo", "romeocoloss@gmail.com");
            firstCostomer.Login();

            Costomer secondCostomer = new Costomer("Mario", "Rossi", "m.rossi99@hotmail.com");
            secondCostomer.Login();


            //class Article

            Article article = new Article("Face mask", 15.54);
            //Article article2 = new Article  (" Sometime ", 50.99, );

            article.List();
            article.Retrieve(0);
            article.Destroy(0);

            Console.WriteLine(article.Description);

            article.Description = "articolo"; 


            Console.WriteLine($"{article.Description} price is : {article.Price}");

            

            OrderHeader orderHeader = new OrderHeader(20, DateTime.Now);

            orderHeader.List();
            orderHeader.Retrieve(0);
            orderHeader.Destroy(0);
            
            Console.WriteLine($"Date: {orderHeader.Date}, UserID: {orderHeader.UserId}");


            Management management = new Management()


            //article2.Order(secondCustomer);  


            
        }
    }
}
*/


using System;

namespace ECommerce
{
    class Costomer
    {
        // Fields or Attributes
        // Più privati possibili

        // Properties
        // getter - setter

        // private string _X
        // _X -> Underscore convenzione che indica attributo privato

        protected int Id;
        protected string FirstName;
        protected string LastName;
        protected string Adress;
        protected int PostalCode;
        protected string Email;
        protected string Password;
        public int Age { get; set;}

        // Constructor
        public Costomer(string firstName, string lastName, string email)
        {
            // Called on instantiation
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }
    
        // Methods
        // visibility - returned value - MethodName()
        public void Login()
        {
            Console.WriteLine($"Hi {this.FirstName} {this.LastName}, you are logged in.");
        }
        public void CheckOut()
        {
            Console.WriteLine("Product(s) purchased.");
        }
        public void MyOrders()
        {
            Console.WriteLine("These are your orders.");
        }
        public void WishList()
        {
            Console.WriteLine("This is your wishlist.");
        }
        public void AddToCart()
        {
                Console.WriteLine("article added to cart!");
        }
        public void Signin()
        {
            Console.WriteLine("You are now signed in.");
        }
        }

}