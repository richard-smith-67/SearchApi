using SearchApi.Dtos;

namespace SearchApi.Data
{
    public interface IPersonRepository
    {
        public List<PersonDto> GetAll();
    }
}