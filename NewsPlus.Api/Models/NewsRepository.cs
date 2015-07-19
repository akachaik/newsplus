using System.Collections.Generic;
using System.Linq;
using NewsPlus.Api.Controllers;

namespace NewsPlus.Api.Models
{
    public class NewsRepository : INewsRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public NewsRepository()
        {
            _applicationDbContext = new ApplicationDbContext();
        }
        public List<News> GetAll()
        {
            //return new List<News>()
            //{
            //    new News {Id = 1, Title = "News 1", Body = "Body 1"},
            //    new News {Id = 2, Title = "News 2", Body = "Body 2"},
            //    new News {Id = 3, Title = "News 3", Body = "Body 3"}
            //};
            return _applicationDbContext.Newses.ToList();
        }
    }

    public interface INewsRepository
    {
        List<News> GetAll();
    }
}