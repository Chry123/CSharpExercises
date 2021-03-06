




//Program.cs

/*using System;
using ExLinq;

namespace ESExLinq
{
        class ESSExLinq
        {
            public static void Main(string[] args)
            {
                var cities = ExLinq.Filtering("Firenze");

                foreach (var city in cities)
                {
                    Console.WriteLine("E' una citta");
                }
            }

        }

}
*/


using System;
using System.Collections.Generic;
using System.Linq;




// LINQ - Languace integrade query 

//SELECT col1, col2 From nome_tabella;


/* from element in collection 
where element ==    "qualcosa"
*/



namespace ESExLinq {

    class ExLinq
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
    }
}