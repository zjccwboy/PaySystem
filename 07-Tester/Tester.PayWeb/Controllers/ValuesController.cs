using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tester.PayWeb.Models;

namespace Tester.PayWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private TestPayDBContext TestDbContext { get; set; }

        public ValuesController(TestPayDBContext dbContext)
        {
            this.TestDbContext = dbContext;
        }


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            TestDbContext.Add(new Tuser { Name = "fuck", Email = "abced@aaaa.com" });
            TestDbContext.SaveChanges();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
