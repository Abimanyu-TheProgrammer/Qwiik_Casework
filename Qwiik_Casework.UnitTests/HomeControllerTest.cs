using Qwiik_Casework.Controllers;
using Qwiik_Casework.Services;
using Moq;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace Qwiik_Casework.UnitTests;

public class HomeControllerTest
{
    [Fact]
    public void Get_ShowFib_ReturnsIntegerArray()
    {
        // Arrange
        var mockFibService = new Mock<IFibonacciService>();
        var mockQueueService = new Mock<IQueueService>();
        var mockSortService = new Mock<ISortService>();
        var mockTriService = new Mock<ITriangleService>();
        var sut = new HomeController(
            mockFibService.Object,
            mockQueueService.Object,
            mockSortService.Object,
            mockTriService.Object);
        // Act
        var result = sut.showFib(1);

        // Assert
        result.Should().BeOfType<int[]>();
    }

    [Fact]
    public void Get_ShowQueue_ReturnsString()
    {
        // Arrange
        var mockFibService = new Mock<IFibonacciService>();
        var mockQueueService = new Mock<IQueueService>();
        var mockSortService = new Mock<ISortService>();
        var mockTriService = new Mock<ITriangleService>();
        var sut = new HomeController(
            mockFibService.Object,
            mockQueueService.Object,
            mockSortService.Object,
            mockTriService.Object);
        // Act
        var result = sut.showQueue();

        // Assert
        result.Should().BeNull();
    }

    [Fact]
    public void Get_ShowTri_ReturnsString()
    {
        // Arrange
        var mockFibService = new Mock<IFibonacciService>();
        var mockQueueService = new Mock<IQueueService>();
        var mockSortService = new Mock<ISortService>();
        var mockTriService = new Mock<ITriangleService>();
        var sut = new HomeController(
            mockFibService.Object,
            mockQueueService.Object,
            mockSortService.Object,
            mockTriService.Object);
        // Act
        var result = sut.showTri(1,2,3);

        // Assert
        result.Should().BeNull();
    }

    [Fact]
    public void Get_ShowSort_ReturnsIntegerArray()
    {
        // Arrange
        var mockFibService = new Mock<IFibonacciService>();
        var mockQueueService = new Mock<IQueueService>();
        var mockSortService = new Mock<ISortService>();
        var mockTriService = new Mock<ITriangleService>();
        var sut = new HomeController(
            mockFibService.Object,
            mockQueueService.Object,
            mockSortService.Object,
            mockTriService.Object);
        // Act
        var result = sut.showSort();

        // Assert
        result.Should().BeOfType<int[]>();
    }
}