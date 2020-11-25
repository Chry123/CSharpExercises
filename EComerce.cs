using System;


namespace EComerce
 {

    class Custumer
    {
             
             // Fields or Attribute

            protected int Id;
            
            protected string Name;

            protected string SurName;

            protected string LastName;

            protected string Email;

            protected string Password;

            //
            // visibilità -valore di ritorno -NomeMetodo();

            public Custumer(string name,string surName){
                this.Name=name;
                this.SurName=surName;

            }

        public void Login()
        {
            Console.WriteLine("Your a logged in.");
        }

        public void Aquista()
        {
            Console.WriteLine("Your a buy .");
        }

        public  void IMieiOrdini()
        {
            Console.WriteLine("Your storage.");
        }

        public void WishList()
        {
            Console.WriteLine("Your WhistList.");
        }

        public void Carello()
        {
            Console.WriteLine("Your shopping cart .");
        }
        public void Registrazione()
        {
            Console.WriteLine("Your Registration .");
        }

    }








} 



