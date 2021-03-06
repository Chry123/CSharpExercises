using System;
using System.Collections.Generic;

namespace ECommerce
{
    
    class Customer 
    {
        // Fields 
        public int Id { get; set; }
        public string FirstName { get; }
        public string LastName { get;  }
        public int Age { get; }
        public string Address { get; }
        public int Zip { get; }
        public string City { get;}
        public string Email { get; }
        public string Password { get; }

        // Properties
        // Constructor
        public Customer(string firstName, string lastName, int age, string email)
                {
                    this.FirstName = firstName;
                    this.LastName = lastName;
                    this.Email = email;
                    this.Age = age;
                }
        
        // Methods
        public void Login()
        {
            Console.WriteLine($"Hi, {this.FirstName} {this.LastName}, age {this.Age}, you are logged in..");
        }
        public void AddToCart()
        {
            Console.WriteLine("Product added to cart");
        }
        public void MyOrders()
        {
            Console.WriteLine("These are your orders");
        }
        public void WishList()
        {
            Console.WriteLine("This is your wishlist");
        }
        public void Cart()
        {
            Console.WriteLine("This is your cart");
        }
        public void Registration()
        {
            Console.WriteLine("You are registering");
        }
    }
    class Article
    {

        public int Id { get; }
        public string Description { get; }
        public double Price { get; set; }
        public int Stock { get; }
        public string Sku  { get; } 
        public double IVA { get; set; }
        public string Restrictions { get; set; }


        class Articless
        {
        public double IVA { get; set; }
        public string Restrictions { get; set; }
        }

        // Constructor
        public Article (string description, double price, string restricted)
        {
            this.Description = description;
            this.Price = price;
            this.Restrictions = restricted;
        }

        // Methods
        public void CreateArticle()
        {
            Console.WriteLine("You created an article");
        }
        public void RetrieveArticle(int id)
        {
            Console.WriteLine($"You are retrieving the {this.Description} article which costs {this.Price} and has {id} as Id");
        }
        public void Update()
        {
            Console.WriteLine("You updated an article");
        }

       
        public void DestroyArticle(int id)
        {
            Console.WriteLine($"You deleted the {this.Description} article which costs {this.Price} and has {id} as Id");
        }
    }


        class OrderHeader
    {
        //Fields
        private int Id;
        private int OrderNumber; 
        private DateTime Date;
        private int UserId;

        //Methods
        public void CreateOrder()
        {
            Console.WriteLine("You created an article");
        }
        public void DestroyOrder()
        {
            Console.WriteLine("You deleted the this article");
        }
        public void ListOrder()
        {
            Console.WriteLine("This is the list of your order headers");
        }        

    }

    class Admin 
    {
        // Fields 
        public int Id { get; set; }
        public string FirstName { get; }
        public string LastName { get;  }
        public string Administrator {get; }
        public string Email { get; }
        public string Password { get; }

        // Constructor
        public Admin(string firstName, string lastName, string email)
                {
                    this.FirstName = firstName;
                    this.LastName = lastName;
                    this.Email = email;
                }

        // Methods
        public void Login()
        {
            Console.WriteLine($"Hi, {this.FirstName} {this.LastName}, you are logged in..");
        }

        public void ManageOrders()
        {
            Console.WriteLine("You can now manage orders");
        }

        public void ManageArticles()
        {
            Console.WriteLine("You can now manage articles");
        }

        public void ManageCustomers()
        {
            Console.WriteLine("You can now manage cutomers");
        }


    } 

    class OrderDetail
    {
        // Fields
        private int Id;
        private int Id_order;
        private int Id_article;
        private double Price;
        private int qta;
    }

    

    class Cart
    {
        // Fields
        private int Id;
        private int Id_article;
        private int UserId;
        private int qta;

        //Methods
        public void Buy()
        {
            Console.WriteLine("You will soon redirected to payment page");
        }

        public void Empty()
        {
            Console.WriteLine("You removed all articles from cart");
        }

        public void ListCart()
        {
            Console.WriteLine("This is the list of your carts");
        } 

    }

    class Articles
    {
        //Fields
        private List<Article> ArticleList = new List<Article>();

        // to be completed
    }

}


