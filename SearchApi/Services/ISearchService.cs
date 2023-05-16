using SearchApi.Dtos;

namespace SearchApi.Services
{
    public interface ISearchService
    {
        public List<PersonDto> Search(List<PersonDto> people, string searchTerm);
    }
}