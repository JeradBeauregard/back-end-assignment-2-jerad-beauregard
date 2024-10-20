using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.PortableExecutable;


namespace back_end_assignment_2_jerad_beauregard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J3 : ControllerBase
    {

        /// J3 2023 SPECIAL EVENT
        /// https://cemc.uwaterloo.ca/sites/default/files/documents/2023/2023CCCJrProblemSet.html
        /// <summary>
        /// Please review problem linked above
        /// Takes an input of one string which contains a number followed by a sequence of Ys and .s
        /// the number represents the amount of people interested in an event
        /// the following 5 characters represents which days out of 5 that person can go with Y being yes and . being no for that day
        /// the string is N X 5 characters long + 1 for N itself
        /// The program starts by putting the whole string into a character array
        /// it then determines the value of N and stores it in a seperate variable
        /// it then removes N from the chracter Array and stores the remainging informaton in a new array
        ///it then uses a for loop to count which days work the most initialized based on N
        /// the for loop does 5 at a time then removes the 5 it just counted before moving on in the array
        /// the next loop loops through the dayCounts array, if the count is equal to the maximum value of the dayCounts
        /// it will add the index to a list
        /// the list is return with the hghest value indexes, which represent the days with the most votes.
      
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns>
        /// a list of day(s) that are most available for the interested people
        /// </returns>
        /// <example>
        /// GET : http://localhost:5290/api/J3/N=3YY.Y....Y..YYY. -> 4 
        /// GET : http://localhost:5290/api/J3/N=5YY..Y.YY.Y.Y.Y..YY.YY...Y - [2,5]
        /// </example>


        /// example string :  5YY..Y.YY.Y.Y.Y..YY.YY...Y

        [HttpGet(template: "N={input}")]

        public List<int> returnDays(string input)
        {
            char[] NArray = input.ToCharArray();
            int N = Int32.Parse(NArray[0].ToString());
            char[] removeN = NArray.Skip(1).ToArray();

            
            int dayOneCount = 0;
            int dayTwoCount = 0;
            int dayThreeCount = 0;
            int dayFourCount = 0;
            int dayFiveCount = 0;


            for (int i = 0; i < N; i++)
            {
                char[] answers = { removeN[0], removeN[1], removeN[2], removeN[3], removeN[4], };

                if (answers[0] == 'Y')
                {
                    dayOneCount++;
                }
                if (answers[1] == 'Y')
                {
                    dayTwoCount++;
                }
                if (answers[2] == 'Y')
                {
                    dayThreeCount++;
                }
                if (answers[3] == 'Y')
                {
                    dayFourCount++;
                }
                if (answers[4] == 'Y')
                {
                    dayFiveCount++;
                }

                removeN = removeN.Skip(5).ToArray();

            }

            int[] dayCounts = { dayOneCount, dayTwoCount, dayThreeCount, dayFourCount, dayFiveCount };
            List<int> daysList = new List<int>();

            // used a list now instead of array because I learned lists can be added to dynamically

            for(int indexer = 0; indexer < dayCounts.Length; indexer++)
            {


                if(dayCounts[indexer] == dayCounts.Max())
                {
                   

                    daysList.Add(indexer + 1);

                }

            }
            
            return daysList;


        }
    }
}
