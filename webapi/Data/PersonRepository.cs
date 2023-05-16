using Newtonsoft.Json;
using System.Reflection;
using webapi.Dtos;

namespace webapi.Data
{
    public class PersonRepository : IPersonRepository
    {
        private readonly string dataFilePath;

        public PersonRepository()
        {
            dataFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Data", "data.json");
        }

        public List<PersonDto> GetAll()
        {
            var jsonData = File.ReadAllText(dataFilePath);
            var people = JsonConvert.DeserializeObject<List<PersonDto>>(jsonData);
           
            if (people == null)
            {
                // if people is null, initialize it as an empty list
                people = new List<PersonDto>();
            }

            return people;
        }
    }


}
