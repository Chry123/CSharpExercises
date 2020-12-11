using System;
using ExLinq;

namespace program
{
        class program
        {
            public static void Main(string[] args)
            {
                var cities = exLinq.filtering("Firenze");

                foreach (var city in cities)
                {
                    Console.WriteLine("E' una citta");
                }
            }

        }

}