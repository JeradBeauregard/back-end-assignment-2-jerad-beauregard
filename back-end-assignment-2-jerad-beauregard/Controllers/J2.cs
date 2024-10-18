using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace back_end_assignment_2_jerad_beauregard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J2 : ControllerBase
    {
        /// <summary>
        /// takes a string input of pepper names (with , seperating them) splits them into an array
        /// checks each array item for matching value, assigns scoville value based on input value
        /// ouputs total scoville
        /// </summary>
        /// <param name="ingredients"></param>
        /// <returns><
        /// total scoville of all ingredients
        /// /returns>
        /// <example>
        /// GET : http://localhost:5290/api/J2/Peppers&Ingredients=Poblano%2CCayenne%2CThai%2CPoblano -> 118000
        /// GET : http://localhost:5290/api/J2/Peppers&Ingredients=Habanero%2CHabanero%2CHabanero%2CHabanero%2CHabanero -> 625000
        /// GET : http://localhost:5290/api/J2/Peppers&Ingredients=Poblano%2CMirasol%2CSerrano%2CCayenne%2CThai%2CHabanero%2CSerrano -> 278500
        /// </example>



        [HttpGet(template:"Peppers&Ingredients={ingredients}")]

        /*
         int Poblano = 1500;
        int Mirasol = 6000;
        int Serano = 15500;
        int Cayenne = 40000;
        int Thai = 75000;
        int Habanero = 125000;
        */

        public int addScoville(string ingredients)
        {
            string[] ingredientList = ingredients.Split(",");

            int scoville = 0;

            foreach (string i in ingredientList)
            {
                if (i == "Poblano")
                {
                    scoville = scoville + 1500;
                }
                if (i == "Mirasol")
                {
                    scoville = scoville + 6000;
                }
                if (i == "Serrano")
                {
                    scoville = scoville + 15500;
                }
                if (i == "Cayenne")
                {
                    scoville = scoville + 40000;
                }
                if (i == "Thai")
                {
                    scoville = scoville + 75000;
                }
                if (i == "Habanero")
                {
                    scoville = scoville + 125000;
                }
            }



            return scoville;

        }

            }
}
