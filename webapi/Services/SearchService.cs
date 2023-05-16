using System;
using webapi.Dtos;

namespace webapi.Services
{
    public class SearchService : ISearchService
    {
        public List<PersonDto> Search(List<PersonDto> people, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                throw new ArgumentException("Search term cannot be empty");
            }

            return people.Where(p =>
            (p.first_name + " " + p.last_name + " " + p.email)
            .IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
            .ToList();
        }
    }
}
