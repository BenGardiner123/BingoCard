using System;

namespace BingoCard
{
    public class Menu {
         public string menu;

        public Menu()
        {
           
        }

        public void makeCardMenu(){

        
        }
        public static bool isSqr(int num)
        {
        // get the square root WITH any fractional component 
        double sq1 = Math.Sqrt( num );
            
        // get square root with fraction truncated by casting as an int
        int sq2 = (int)Math.Sqrt( num );
            
        // compare the numbers as doubles and see if equal
        // if the fraction part of sq1 was zero (perfect square), then 
        // the int and the double will be equivalent
        if ( sq1 == (double)sq2 )
            return true;
        return false;
        

        }

    } 

        
}

/* var userinput = Console.ReadLine();
            int menuCheck;
            bool correctInput = int.TryParse(userinput, out menuCheck);
            if (correctInput)
            {
                Menu();
            }
            else 
            {
                Console.Write("You have not entered a number. . .Goodbye");
            }
 */