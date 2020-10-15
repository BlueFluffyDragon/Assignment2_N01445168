using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace Assignment2_N01445168.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// GET: /api/J2/DiceGame/6/8 
        /// </summary>
        /// <param name="m">Number of sides in first dice</param>
        /// <param name="n">Number of sides in second dice</param>
        /// <returns>There are 5 total ways to get the sum 10.</returns>
        [Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet]

        public string DiceGame(int m, int n)
        {
            int counter = 0;
            
            //if dice1 is >= 1
            for (int dice1 = m; dice1 >= 1; dice1--)
            {
                for (int dice2 = n; dice2 >= 1; dice2--)
                {
                    // checks if dice 1 and dice 2 sides add upto exactly 10
                    if (dice1 + dice2 == 10)
                    {
                        //if it does add to 10 then the counter will increase by 1 
                        counter++;
                    }
                }
            }

            string message = "There are " + counter + " total ways to get the sum 10.";

            return message;
        }
    }
}

