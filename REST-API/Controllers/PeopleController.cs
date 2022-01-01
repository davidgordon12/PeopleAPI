using REST_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace REST_API.Controllers
{
    /// <summary>
    /// API for selecting, creating and removing people from a list
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "David", LastName = "Gordon", id = 1 });
            people.Add(new Person { FirstName = "John", LastName = "Deer", id = 2 });
            people.Add(new Person { FirstName = "Jane", LastName = "Doe", id = 3 });
        }

        /// <summary>
        /// Gets a list of first names of all people.
        /// </summary>
        /// <returns></returns>
        [Route("api/People/GetFirstNames")]
        [HttpGet]
        public List<string> GetFirstNames()
        {
            List<string> FirstNames = new List<string>();

            foreach (var entity in people)
            {
                FirstNames.Add(entity.FirstName);
            }
            return FirstNames;
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person n_person)
        {
            people.Add(n_person);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
            people.Remove(people.Where(x => x.id == id).FirstOrDefault());
        }
    }
}
