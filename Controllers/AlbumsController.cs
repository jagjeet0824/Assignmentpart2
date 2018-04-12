using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using part2.Models;

namespace part2.Controllers
{
    [Produces("application/json")]
    [Route("api/Albums")]
    public class AlbumsController : Controller
    {
        private StoreClass db;

        public AlbumsController(StoreClass db)
        {
            this.db = db;
        }

        // GET: api/Albums
        [HttpGet]
        public IEnumerable<Album> Get()
        {
            return db.Albums.ToList();
        }

        // GET: api/Albums/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Albums
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Albums/5
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
