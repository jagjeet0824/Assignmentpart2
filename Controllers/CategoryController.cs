using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using part2.Models;
using Assignment.Models;

namespace part2.Controllers
{
    [Produces("application/json")]
    [Route("api/Category")]
    public class CategoryController : Controller
    {
        private CategoryModel db;

        public CategoryController(CategoryModel db)
        {
            this.db = db;
        }
        // GET: api/Category
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return db.Category_1.ToList();

        }

        // GET: api/Category/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Category
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Category/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
