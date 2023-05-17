using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using MyFabulousCreatures.Controllers;
using MyFabulousCreatures.Models;
using MyFabulousCreatures.Services;

public class CreatureControllerTests
{
    private readonly CreatureController _controller;
    private readonly Mock<ILogger<CreatureController>> _mockLogger;
    private readonly Mock<IStaticFileService<Creature>> _mockService;

    public CreatureControllerTests()
    {
        _mockService = new Mock<IStaticFileService<Creature>>();
        _mockLogger = new Mock<ILogger<CreatureController>>();
        _controller = new CreatureController(_mockService.Object, _mockLogger.Object);
    }

    [Fact]
    public async Task GetCreatureAsync_ReturnsNotFound_WhenCreatureIsNull()
    {
        // Arrange
        const string creatureType = "Dragon";
        const int creatureAge = 1000;
        var creature = new Creature(creatureType, creatureAge);
        _mockService.Setup(s => s.GetImageFileAsync(creature)).ReturnsAsync((FileContentResult) null);

        // Act
        var result = await _controller.GetCreatureAsync(creature);

        // Assert
        Assert.IsType<NotFoundResult>(result);
    }
}