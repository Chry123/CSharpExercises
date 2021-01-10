using System;
using System.Collections.Generic;
using ECommerce;



namespace ECommerce
{
    class Program
    {
        static void Main(string[] args)
        {


            Customer firstCostomer = new Customer("Romeo", "Colosseo", 88 , "romeocoloss@gmail.com");
            firstCostomer.Login();
            Customer secondCustomer = new Customer("Mario", "Rossi", 10 , "m.rossi99@hotmail.com");
            secondCustomer.Login();


            Article article = new Article ("Face mask", 12.44, "No restrictions");
            Article article2 = new Article ("Bottle of wine", 25.85, "Not under 18");

            int firstId = 4;
            article.RetrieveArticle(firstId);
            article.DestroyArticle(3);


        }
    }
}