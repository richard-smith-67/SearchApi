using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SearchApi.Controllers;
using SearchApi.Data;
using SearchApi.Dtos;
using SearchApi.Services;
using Xunit;

namespace SearchApiTests.Controllers
{
    public class SearchControllerTests
    {
        private readonly SearchController _controller;
        private readonly Mock<ISearchService> _mockSearchService;
        private readonly Mock<IPersonRepository> _mockPersonRepository;

        public SearchControllerTests()
        {
            _mockSearchService = new Mock<ISearchService>();
            _mockPersonRepository = new Mock<IPersonRepository>();
            _controller = new SearchController(_mockSearchService.Object, _mockPersonRepository.Object);
        }

        [Fact]
        public void Search_WhenSearchTermIsFound_ReturnsOkWithCorrectData()
        {
            // Arrange
            var searchTerm = "tes";
            var testPersonList = new List<PersonDto>
            {
                new PersonDto { first_name = "test", last_name = "", email = "" }
            };

            _mockPersonRepository.Setup(repo => repo.GetAll()).Returns(testPersonList);
            _mockSearchService.Setup(s => s.Search(It.IsAny<List<PersonDto>>(), searchTerm)).Returns(testPersonList);

            // Act
            var result = _controller.Search(searchTerm);

            // Assert
            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            var model = okResult.Value.Should().BeAssignableTo<List<PersonDto>>().Subject;

            model.Count.Should().Be(1);
            model[0].first_name.Should().Be("test");
        }

        [Fact]
        public void Search_WhenCalledWithoutSearchTerm_ReturnsBadRequest()
        {
            // Arrange
            string searchTerm = string.Empty;

            // Act
            var result = _controller.Search(searchTerm);

            // Assert
            var badRequestResult = result.Should().BeOfType<BadRequestObjectResult>().Subject;
            badRequestResult.Value.Should().Be("Search term cannot be empty");
        }
    }

}