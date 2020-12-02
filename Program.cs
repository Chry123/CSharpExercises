using System;
using ECommerce;

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

            
        }
    }
}