using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calcclasslib101;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 

namespace apicalc.Controllers
{
    public class HomeController : Controller
    {
        calc mycalc = new calc();

        // GET: HomeController

        [HttpGet("/avarage")]
        public int avarage([FromQuery] int[] nums)
        {
            
            return  mycalc.Avarage(nums);
        }
        [HttpGet("/smallest")]
        public int smallest([FromQuery] int[] nums)
        {
             
            return mycalc.smallest(nums);

        }
        [HttpGet("/largest")]
        public int largest([FromQuery] int[] nums)
        {
             
            return mycalc.largest(nums);    

        }
    }
}

