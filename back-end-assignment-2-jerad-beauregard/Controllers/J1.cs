using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace back_end_assignment_2_jerad_beauregard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class J1 : ControllerBase
    {


        /// <summary>
        /// Takes in the amount of collisions and the amount of packages to determine the players score.
        /// packages are worth 50 points, each collision substracts 10 points from the total
        /// if packages is greater than collisions and extra 500 points is awarded.
        /// </summary>
        /// <param name="collisions"></param>
        /// <param name="packages"></param>
        /// <returns>
        /// The total score of the player
        /// </returns>
        /// <example>
        /// POST : http://localhost:5290/api/J1/Delivedroid/Collisions=2&Deliveries=5 -> 730
        /// POST : http://localhost:5290/api/J1/Delivedroid/Collisions=10&Deliveries=0 -> -100
        /// POST : http://localhost:5290/api/J1/Delivedroid/Collisions=3&Deliveries=2 -> 70
        /// </example>
        /// 

        [HttpPost(template: "Delivedroid/Collisions={collisions}&Deliveries={packages}")]

        public int returnData(int collisions,int packages)
        {


            int points = (packages * 50) - (collisions * 10);
            
            if(packages > collisions)
            {
                points = points + 500;
            }

            return points;


        }


    }
}
