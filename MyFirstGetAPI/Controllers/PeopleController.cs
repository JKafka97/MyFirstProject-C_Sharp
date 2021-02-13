using MyFirstGetAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MyFirstGetAPI.Controllers
{
    public class PeopleController : ApiController
    {
        private List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Corey", Id = 1 });
            people.Add(new Person { FirstName = "Bob", LastName = "Mac", Id = 2 });
            people.Add(new Person { FirstName = "Josh", LastName = "Duck", Id = 3 });
        }
        
        [Route("api/People/GetFirstName/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstNames(int userId, int age)
        {
            List<string> output = new List<string>();
            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }

            return output;
        }
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val1)
        {
            people.Add(val1);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}