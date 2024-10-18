using Microsoft.AspNetCore.Mvc;

namespace back_end_assignment_2_jerad_beauregard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J22 : ControllerBase
    {
        /// J2 YEAR 2018
        ///  https://cemc.uwaterloo.ca/sites/default/files/documents/2018/2018CCCJrProblemSet.html
        /// <summary>
        /// Please review problem linked above.
        /// Takes a string input of a series of Cs and .s indicating if a parking spot was used or not.
        /// Anyhow dayone is a string of characters with the parking spots either filled (C) or unfilled (.)
        ///
        /// day two is the same- and they are the same length
        /// day one and day two are put into their own character arrays which are then compared using a for loop set to iterate to the amount of N, to see 
        /// how many parking spots were filled on both days. or how which indexes both have 'c' at the same index number
        /// </summary>
        /// <param name="N"></param>
        /// <param name="dayOne"></param>
        /// <param name="dayTwo"></param>
        /// <returns>
        /// the amount of parking spots used on both days (ammount of matching indexes in each array)
        /// </returns>
        /// <example>
        /// GET : http://localhost:5290/api/J22/parkingspaces=5&dayone=cc..c&daytwo=.cc.. -> 1
        /// GET : http://localhost:5290/api/J22/parkingspaces=7&dayone=ccccccc&daytwo=c.c.c.c -> 4
        /// </example>

        [HttpGet(template:"parkingspaces={N}&dayone={dayOne}&daytwo={dayTwo}")]

        public int returnSpaces(int N, string dayOne, string dayTwo)
        {
            char[] dayOneArray = dayOne.ToCharArray();
            char[] dayTwoArray = dayTwo.ToCharArray();
            int count = 0;

            for (int i = 0; i < N; i++)
            {

                if (dayOneArray[i] == dayTwoArray[i] && dayOne[i] == 'c')
                {
                    count++;
                }



            }
            return count;
        }
    }
}
