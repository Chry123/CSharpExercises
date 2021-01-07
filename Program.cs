using System;
using System.Collections.Generic;
using ECommerce;

namespace Customers
{
    class Customers 
    {
        public  static void  Main(string[] args)
        {

      
                Customer firstCostomer = new Customer("Romeo", "Colosseo", "romeocoloss@gmail.com");
                firstCostomer.Login();
                Customer secondCustomer = new Customer("Mario", "Rossi", "m.rossi99@hotmail.com");
                secondCustomer.Login();
                

                var list = new List<string> { "Luigi", "Mario", "Felipe" };

                    foreach (var name in list)
                    {
                    Console.WriteLine($"{name}");
                    }

                //Customer.GetListOfArticles();
        }

    }
                   
            
} 


