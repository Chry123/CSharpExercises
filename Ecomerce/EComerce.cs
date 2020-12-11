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

    class Article
    {
        // private int Id; // Field
        // private int Id { get; set; }; // Property
        public int Id { get; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        private int TaxeRate;
        
        public Article(string description, double price)
        {
            this.Description = description;
            this.Price = price;
        }

        public void List() 
        {
            Console.WriteLine("List all articles");
        }

        public void Create()
        {
            Console.WriteLine("Create new article");
        }

        public void Retrieve(int id)
        {
            Console.WriteLine($"Id: {this.Id}, description: {this.Description}, price: {this.Price}");
        }

        public void Update()
        {
            Console.WriteLine("Update your article.");
        }

        public void Destroy(int id)
        {
            Console.WriteLine($"You just destroyed item #{id}");
        }
    }

    //OrderHeader
    class OrderHeader 
    {
        public int Id { get; }
        public string OrderNumber { get; }
        public DateTime Date { get; }
        public int UserId { get; }

        public OrderHeader(int userId, DateTime date)
        {
            //this.UserId or UserId 
            this.UserId = userId;
            this.Date = date;
        }

        public void Create()
        {
            Console.WriteLine("Create new order");
        }
        public void List() 
        {
            Console.WriteLine("List all orders");
        }
        public void Retrieve(int id)
        {
            Console.WriteLine($"Id: {this.Id}, OrderNumber: {this.OrderNumber}, UserId: {this.UserId}, Date: {this.Date}");
        }
        public void Update()
        {
            Console.WriteLine("Update your order");
        }
        public void Destroy(int id)
        {
            Console.WriteLine("You have cancelled this order ");
        }
    }

    class Management 
    {

        private int Admin;

        private Management ( int Admin)
        {
            this.Admin = Admin;
        }

       public void Login()
        {
            Console.WriteLine(" logged in ");
        }
        public void OrderControl()
        {
             Console.WriteLine(" order management ");
        }
        public void OrderArticle()
        {
            Console.WriteLine(" Article management ");
        }
        public void OrderCustomer()
        {
            Console.WriteLine(" Customer management ");
        }


    }

    class OrderDetail
    {
        private int Id; 
        public int idOrder;
        public int idArticle;
        private float Price;
        private int qta;


    }


    class Cart
    {
        private int Id;
        private int idArticle;
        private string Customer;
        private int qta;

        public void Buy()
        {
            Console.WriteLine(" Buy... ");
        }
        public void Empty()
        {
            Console.WriteLine(" Empty cart.. ");
        }
        public void List()
        {
            Console.WriteLine(" List... ");
        }

    }
}