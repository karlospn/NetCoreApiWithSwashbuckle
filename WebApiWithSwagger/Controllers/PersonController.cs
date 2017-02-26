using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApiWithSwagger.Models;

namespace WebApiWithSwagger.Controllers
{
    /// <summary>
    /// Person Controller
    /// </summary>
    [Route("api/persons")]
    [Produces("application/json")]
    public class PersonController : Controller
    {
        protected List<Person> _personList;

        /// <summary>
        /// Initialize a new instance of PersonController.
        /// Initialize the list of all the persons.
        /// </summary>
        public PersonController()
        {
            _personList = new List<Person>
            {
                new Person {FirstName = "John", LastName = "Smith"},
                new Person {FirstName = "Rob", LastName = "Myers"},
                new Person {FirstName = "Andrew", LastName = "Johnson"},
                new Person {FirstName = "Stuart", LastName = "Robson"}
            };
        }
        // GET api/values
        /// <summary>
        /// Get all persons
        /// </summary>
        /// <returns>A list of Persons</returns>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _personList;    
        }

        // GET api/values/5
        /// <summary>
        /// Get a person list filtered by firstName
        /// </summary>
        /// <param name="FirstName"></param>
        /// <returns>A list of persons matched by the FirstName paramater</returns>
        [HttpGet("{FirstName}")]
        public IEnumerable<Person> Get(string FirstName)
        {
            return _personList.Where(x => x.FirstName == FirstName);
        }

        // POST api/values
        /// <summary>
        /// Insert a Person 
        /// </summary>
        /// <param name="person">A person class to be inserted</param>
        /// <remarks>
        /// .
        ///  
        ///     POST /Todo
        ///     {
        ///        "FirstName": "Edward",
        ///        "LastName": "Karloff"
        ///     }
        /// </remarks>
        [HttpPost]
        [ProducesResponseType(typeof(OkObjectResult), 200)]
        [ProducesResponseType(typeof(BadRequestObjectResult), 400)]
        public IActionResult Post([FromBody]Person person)
        {
            if (ModelState.IsValid)
            {
                _personList.Add(new Person {FirstName = person.FirstName, LastName = person.LastName});
                return Ok(person);
            }
            return BadRequest(ModelState);
        }

        // DELETE api/values/5
        /// <summary>
        /// Deletes a Person
        /// </summary>
        /// <param name="person">A person class whom is going to be erased</param>
        [HttpDelete("")]
        public void Delete([FromBody]Person person)
        {
            if (ModelState.IsValid)
            {
                _personList.Remove(person);
            }
        }
    }
}
