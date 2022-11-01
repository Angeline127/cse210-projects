//DIE GAME//
//AUTHOR:: Angeline Nyepen//

using System;



namespace Unit02.Game
{
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.
    /// <summary>
    /// A small cube with a different number of spots on each of its six sides.
    /// 
    /// The responsibility of Die is to keep track of its currently rolled value and the points its
    /// worth.
    /// </summary> 

    // 2) Create the class constructor. Use the following method comment.

    /// <summary>
    /// Constructs a new instance of Die.
    /// </summary>


    // 3) Create the Roll() method. Use the following method comment.

    /// <summary>
    /// Generates a new random value and calculates the points for the die. Fives are 
    /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
    /// </summary>

    public class Die
    {
        public int randomvalue = 0;
        public int numbers = 0;
        
        public Die()
        { 
            
        }

        public void Roll()
        {
            Random roll = new Random();
            int randomvalue = roll.Next(1, 6);
            if (randomvalue == 5)
            {
                numbers = 50;
            }
            else if (randomvalue == 1)
            {
                numbers = 100;
            }
            else
            {
                numbers = 0;
            }
        }

    }






}