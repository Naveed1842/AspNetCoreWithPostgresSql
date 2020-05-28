using System.Collections.Generic;
using System.Linq;
using ArticleApp.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace ArticleApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ArticleController : ControllerBase
    {
        private DataContext _context;

        public ArticleController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult GetArticle()
        {
            return Ok(_context.Articles.ToList());
        }
    }
}