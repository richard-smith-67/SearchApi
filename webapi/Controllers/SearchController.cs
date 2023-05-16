using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using webapi.Data;
using webapi.Services;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService _searchService;
        private readonly IPersonRepository _personRepository;

        public SearchController(ISearchService searchService, IPersonRepository personRepository)
        {
            _searchService = searchService;
            _personRepository = personRepository;
        }

        [HttpGet]
        public IActionResult Search(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm)) 
            { 
                return BadRequest("Search term cannot be empty"); 
            }
            
            var people = _personRepository.GetAll();
            var results = _searchService.Search(people, searchTerm);
            return Ok(results);
        }
    }

}
