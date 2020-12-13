using System;
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