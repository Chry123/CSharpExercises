using System;
using ExLinq;

namespace ESExLinq2
{
        /*class ExLinq2
        {
            public static void Main(string[] args)
            {
                var cities = ExLinq.Filtering("Firenze");

                foreach (var city in cities)
                {
                    Console.WriteLine("E' una citta");
                }
            }


            class Mountains
            {
                public static void Main(string[] args)
                {
                var result = ESExLinq.Mountains.ListOfMountains(""); 

                     Console.WriteLine(result);

                var NameMontain = "Monte Falco, 1658, Parco Foreste Casentinesi ; Monte Falterona, 1654, Parco Foreste Casentinesi; Monte Fumaiolo, 1407, Appennino Tosco Emiliano";
                
                

                    foreach (var element  in result )
                    {
                        Console.WriteLine(NameMontain.Split(',')[0].Trim()); 
                    } 


                }

            }

}


