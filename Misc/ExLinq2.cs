using System;
using System.Collections.Generic;
using System.Linq;





namespace ESExLinq {

    /*class ExLinq
    {
       public static IEnumerable<string> Filtering(string NameCities)
        {
            var cities = new string [] {"Lucca","Arezzo","Firenze","Siena"};


            //LINQ
            //var query= 

            //START
            var query =

            from city in cities 

            where city == NameCities

            select city;                        
            
            foreach (var city in query)
            {
                Console.WriteLine(city);
            }

            //END
            return query;  
         }

            }*/

        



            class Mountains
            {
            
             //public static IEnumerable<string> Filtering(string NameCities)
                public static string[] ListOfMountains(string NameMontain)
                {
                    string[] mountains = NameMontain.Split(';');

                    return mountains;                    
                }

            }
    
    
}