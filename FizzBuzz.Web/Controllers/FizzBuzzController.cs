using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Core;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Web.Controllers
{
    [Route("api/[controller]")]
    public class FizzBuzzController : Controller
    {
        private FizzBuzzProvider provider;
        public FizzBuzzController(FizzBuzzProvider provider)
        {
            this.provider = provider;
        }

        // GET api/FizzBuzz
        [HttpGet]
        public IEnumerable<string> Get() => provider.GetFizzBuzzMulti(100);

        // GET api/FizzBuzz/5
        [HttpGet("{num}")]
        public string Get(int num) => provider.GetFizzBuzzSingle(num);

        [HttpGet("multi/{num}")]
        public string[] GetMulti(int num) => provider.GetFizzBuzzMulti(num);

    }
}
