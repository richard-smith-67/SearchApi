using webapi.Dtos;

namespace webapi.Data
{
    public interface IPersonRepository
    {
        public List<PersonDto> GetAll();
    }
}