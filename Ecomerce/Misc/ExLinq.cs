using System;
using System.Collections.Generic;
using System.Linq;




// LINQ - Languace integrade query 

//SELECT col1, col2 From nome_tabella;


/* from element in collection 
where element ==    "qualcosa"
*/



namespace ExLinq {

    class exLinq
    {
       public static IEnumerable<string> filtering(string NameCities)
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
    }
}