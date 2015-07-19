using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.OData;
using NewsPlus.Api.Models;

namespace NewsPlus.Api.Controllers
{
    public class NewsController : ApiController
    {
        private readonly INewsRepository _repository;

        public NewsController()
        {
            _repository = new NewsRepository();
        }

        public NewsController(INewsRepository repository)
        {
            _repository = repository;
        }

        // GET api/<controller>
        [EnableQuery(PageSize = 2)]
        public IQueryable<News> Get()
        {

            return _repository.GetAll().AsQueryable();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "test value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }


}