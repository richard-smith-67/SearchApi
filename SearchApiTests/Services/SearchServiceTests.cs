using FluentAssertions;
using SearchApi.Dtos;
using Xunit;

namespace SearchApi.Services.Tests
{
    public class SearchServiceTests
    {
        private readonly SearchService _searchService;

        public SearchServiceTests()
        {
            _searchService = new SearchService();
        }

        [Fact]
        public void Search_WhenSearchTermIsInFirstName_ReturnsCorrectData()
        {
            // Arrange
            var searchTerm = "tes";
            var testPersonList = new List<PersonDto>
            {
                new PersonDto { first_name = "test", last_name = "", email = "" },
                new PersonDto { first_name = "another", last_name = "", email = "" }
            };

            // Act
            var result = _searchService.Search(testPersonList, searchTerm);

            // Assert
            result.Count.Should().Be(1);
            result[0].first_name.Should().Be("test");
           
        }

        [Fact]
        public void Search_WhenSearchTermIsInSurname_ReturnsCorrectData()
        {
            // Arrange
            var searchTerm = "tes";
            var testPersonList = new List<PersonDto>
            {
                new PersonDto { first_name = "", last_name = "test", email = "" },
                new PersonDto { first_name = "another", last_name = "", email = "" }
            };

            // Act
            var result = _searchService.Search(testPersonList, searchTerm);

            // Assert
            result.Count.Should().Be(1);
            result[0].last_name.Should().Be("test");

        }

        [Fact]
        public void Search_WhenSearchTermIsInEmail_ReturnsCorrectData()
        {
            // Arrange
            var searchTerm = "tes";
            var testPersonList = new List<PersonDto>
            {
                new PersonDto { first_name = "", last_name = "", email = "test" },
                new PersonDto { first_name = "another", last_name = "", email = "" }
            };

            // Act
            var result = _searchService.Search(testPersonList, searchTerm);

            // Assert
            result.Count.Should().Be(1);
            result[0].email.Should().Be("test");

        }

        [Fact]
        public void Search_WhenCalledWithoutSearchTerm_ThrowsArgumentException()
        {
            // Arrange
            string searchTerm = string.Empty;
            var testPersonList = new List<PersonDto>
            {
                new PersonDto { first_name = "test",   last_name = "", email = "" },
                new PersonDto { first_name = "another", last_name = "", email = "" }
            };

            // Act
            Action act = () => _searchService.Search(testPersonList, searchTerm);

            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Search term cannot be empty");
        }
    }

}