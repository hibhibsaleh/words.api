using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vinformatix.Infrastructure;
using Words.Api.Data;
using Words.Api.Dto;
using Words.Api.Entity;

namespace Words.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class WordsController : ControllerBase
    {
        // Dependency Injection
        private readonly WordsDataContext _context;

        public WordsController(WordsDataContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //[ProducesResponseType(typeof(Response<List<GetWordDto>>), (int)HttpStatusCode.OK)]
        //[ProducesResponseType(typeof(Response), (int)HttpStatusCode.BadRequest)]
        //public ActionResult<IEnumerable<string>> GetAll(GetWordDto getAllWords)
        //{
            
        //}

        //// GET api/words/5
        //[HttpGet("[controller]/{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        // Endpoint Type
        [HttpPost("[controller]")]
        // Expected Response Types
        [ProducesResponseType(typeof(Response<GetWordDto>), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(Response), (int)HttpStatusCode.BadRequest)]
        public GetWordDto Post(string word)
        {
            // Create a new Word Entity
            var entity = new Word();
            // Assign WordName to the string word from user
            entity.WordName = word;

            // Using Dependency Injection
            // Add entity to database
            _context.Add(entity);
            // Save changes to database
            _context.SaveChanges();

            // Return ojbect including Id made by database
            return new GetWordDto{Id = entity.Id, WordName = entity.WordName};
        }

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}