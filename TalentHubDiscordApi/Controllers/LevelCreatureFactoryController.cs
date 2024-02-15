// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;
using MyFabulousCreatures.Infrastructure;

namespace MyFabulousCreatures.Controllers;

[ApiController]
[Route("/api/v1/creatures")]
public class LevelCreatureFactoryController
    : ControllerBase
{
    private readonly ICreatureFactoryService _creatureFactoryService;
    private readonly ILogger<LevelCreatureFactoryController> _logger;

    public LevelCreatureFactoryController(
        ICreatureFactoryService creatureFactoryService,
        ILogger<LevelCreatureFactoryController> logger)
    {
        _creatureFactoryService = creatureFactoryService;
        _logger = logger;
    }

    [HttpGet("{level:int}/{raceId:int}")]
    public async Task<IActionResult> Get(int level, int raceId)
    {
        try
        {
            var result = await _creatureFactoryService.CreateCreatureAsync(level, raceId);
            return File(result.FileContents, result.ContentType);
        }
        catch (FileNotFoundException ex)
        {
            _logger.LogError(ex, "Failed to find creature image for level {Level} and raceId {RaceId}.", level, raceId);
            return NotFound();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while processing the request.");
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }
}