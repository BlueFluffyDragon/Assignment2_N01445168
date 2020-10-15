using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01445168.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// GET: /api/J2/Menu/1/2/3/4
        /// </summary>
        /// <param name="burger">burger number(1)</param>
        /// <param name="drink">drink number(2)</param>
        /// <param name="side">side number(3)</param>
        /// <param name="dessert">dessert number(4)</param>
        /// <returns>Your total calorie count is 691</returns>
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]

        public string Menu(int burger, int drink, int side, int dessert)
        {
            int[] burgerCalories = { 461, 431, 420, 0 };
            int[] drinkCalories = { 130, 160, 118, 0 };
            int[] sidesCalories = { 100, 57, 70, 0 };
            int[] dessertCalories = { 167, 266, 75, 0};
            
            int totalCalories = burgerCalories[burger-1] + drinkCalories[drink-1] + sidesCalories[side-1] + dessertCalories[dessert-1];
            string message = "Your total calorie count is " + totalCalories;
            return message;
        }
    }
}
