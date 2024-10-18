using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


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
        /// next is the part im stuck on. I want the for loop to loop through the daycounts which are stored in an array
        /// and add the max values to a list, using what i have it will work if it only has to output one value, however it wont 
        /// loop around and add a second value in the case that two days are equal
        /// please help i've spent hours on this
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns>
        /// a list of day(s) that are most available for the interested people
        /// </returns>
        /// <example>
        /// GET : http://localhost:5290/api/J3/N=3YY.Y....Y..YYY. -> 4 THIS ONE WORKS
        /// GET : http://localhost:5290/api/J3/N=5YY..Y.YY.Y.Y.Y..YY.YY...Y -4 [4,2] Completely wrong, is it adding the value or the index?
        /// </example>


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

            for(int indexer = 0; indexer < dayCounts.Length; indexer++)
            {

                //if (dayCounts[indexer] > dayCounts[0] && indexer >= dayCounts[1] && indexer >= dayCounts[2] && indexer >= dayCounts[3] && indexer >= dayCounts[4])
                if(dayCounts[indexer] == dayCounts.Max())
                {
                    // It should add the index to the daysList list if the index value is equal to the highest value in the array
                    // add i to list

                  //  int index = dayCounts.indexOf(dayCounts[indexer]);

                    daysList.Add(Array.IndexOf(dayCounts, indexer) + 1);

                }

            }
            
            return daysList;


        }
    }
}
