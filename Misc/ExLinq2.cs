using System.Linq;
using System.Collections.Generic;

namespace ExLINQ
{    
    class Mountains
    {
        public static string[] ListOfMountains(string startingString)
        {
            string[] mountains = startingString.Split(';');
            return mountains;                    
        }
    }
} 