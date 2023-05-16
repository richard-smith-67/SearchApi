using webapi.Dtos;

namespace webapi.Services
{
    public interface ISearchService
    {
        public List<PersonDto> Search(List<PersonDto> people, string searchTerm);
    }
}