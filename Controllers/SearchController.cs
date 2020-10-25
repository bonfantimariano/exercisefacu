using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExerciseAPI.DbContexts;
using ExerciseAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExerciseAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly SearchDbContext _context;
        private readonly ILogger<SearchController> _logger;

        public SearchController(SearchDbContext context, ILogger<SearchController> logger)
        {
            _context = context;
            _logger = logger;
        }

        

        [HttpPost]
        public IActionResult Search(Search item)
        {
            Search searchItem = new Search();
            searchItem.TextSearched = item.TextSearched;
            searchItem.Email = item.Email;
            searchItem.ResultNumber = item.ResultNumber;
            _context.Search.Add(searchItem);
            _context.SaveChanges();
            return Ok();
        }
    }
}