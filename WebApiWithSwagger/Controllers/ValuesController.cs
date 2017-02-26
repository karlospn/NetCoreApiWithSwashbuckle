using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiWithSwagger.Controllers
{
    /// <summary>
    /// Values Controller
    /// </summary>
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ValuesController : Controller
    {

        /// <summary>
        /// Initialize a new instance of ValuesController
        /// </summary>
        public ValuesController()
        {
            
        }
        // GET api/values
        /// <summary>
        /// Get a list of Values
        /// </summary>
        /// <returns>String list of values</returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        /// <summary>
        /// Get a value based on an ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A value matching by id</returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        /// <summary>
        /// Insert value 
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        /// <summary>
        /// Update values
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        /// <summary>
        /// Delete values
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
