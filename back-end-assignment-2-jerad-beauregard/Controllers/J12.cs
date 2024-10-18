using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace back_end_assignment_2_jerad_beauregard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    // J1 Year 2022 Cupcake Party Problem
    // https://cemc.uwaterloo.ca/sites/default/files/documents/2022/2022CCCJrProblemSet.html

    public class J12 : ControllerBase
    {

        /// <summary>
        /// Please review problem linked above
        /// Takes input of amount of small boxes, and amount of large boxes (of cupcakes)
        /// small box contains 3 cupcakes, large box contains 8 cupcakes
        /// adds total cupcakes together then subtracts 28 to output the remaining amount of cupcakes
        /// </summary>
        /// <param name="smallBoxes"></param>
        /// <param name="largeBoxes"></param>
        /// <returns>
        /// remainging amount of cupcakes
        /// </returns>
        /// <example>
        /// GET : http://localhost:5290/api/J12/largeboxes=2&smallboxes=5 -> 3
        /// GET : http://localhost:5290/api/J12/largeboxes=2&smallboxes=4 -> 0
        /// </example>
        [HttpGet(template: "largeboxes={largeBoxes}&smallboxes={smallBoxes}")]

        public int remainingCupcakes(int largeBoxes, int smallBoxes)
        {

            int smallBoxCupcakes = smallBoxes * 3;
            int largeBoxCupcakes = largeBoxes * 8;

            int cupcakesLeft = (smallBoxCupcakes + largeBoxCupcakes) - 28;

            return cupcakesLeft;

        }




    }
}
