using FluentAssertions;
using Newtonsoft.Json;
using System.Reflection;
using SearchApi.Dtos;
using Xunit;
using SearchApi.Services;

namespace SearchApiTests.Acceptance
{

    // I'm including these specific tests just in case! The SearchService is pretty simple and covered in general tests,
    // so normally I wouldn't test these specifics.
    public class AcceptanceTests
    {
        private SearchService _searchService;
        private List<PersonDto> _testData;

        public AcceptanceTests()
        {
            string dataFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Acceptance", "data.json");
            _testData = LoadTestData(dataFilePath);
            _searchService = new SearchService();
        }

        private List<PersonDto> LoadTestData(string dataFilePath)
        {
            var json = File.ReadAllText(dataFilePath);
            return JsonConvert.DeserializeObject<List<PersonDto>>(json);
        }

        [Fact]
        public void Search_WithTerm_James_Returns_JamesKubu_And_JamesPfeffer()
        {
            // Act
            var results = _searchService.Search(_testData, "James");

            // Assert
            results.Should().HaveCount(2);
            results.Should().Contain(p => p.first_name == "James" && p.last_name == "Kubu");
            results.Should().Contain(p => p.first_name == "James" && p.last_name == "Pfeffer");
        }

        [Fact]
        public void Search_WithTerm_Jam_Returns_JamesKubu_JamesPfeffer_And_ChamlersLongfut()
        {
            // Act
            var results = _searchService.Search(_testData, "jam");

            // Assert
            results.Should().HaveCount(3);
            results.Should().Contain(p => p.first_name == "James" && p.last_name == "Kubu");
            results.Should().Contain(p => p.first_name == "James" && p.last_name == "Pfeffer");
            results.Should().Contain(p => p.first_name == "Chalmers" && p.last_name == "Longfut");
        }

        [Fact]
        public void Search_WithTerm_KateySoltan_Returns_KateySoltan()
        {
            // Act
            var results = _searchService.Search(_testData, "Katey Soltan");

            // Assert
            results.Should().HaveCount(1);
            results.Should().Contain(p => p.first_name == "Katey" && p.last_name == "Soltan");
        }
    }

}
