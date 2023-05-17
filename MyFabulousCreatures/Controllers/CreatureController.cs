// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;
using MyFabulousCreatures.Models;
using MyFabulousCreatures.Services;

namespace MyFabulousCreatures.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class CreatureController : ControllerBase
{
    private readonly IStaticFileService<Creature> _creatureService;
    private readonly ILogger<CreatureController> _logger;

    public CreatureController(
        IStaticFileService<Creature> creatureService,
        ILogger<CreatureController> logger)
    {
        _creatureService = creatureService ?? throw new ArgumentNullException(nameof(creatureService));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    [HttpGet]
    public async Task<IActionResult> GetCreatureAsync([FromQuery] Creature model)
    {
        try
        {
            var creature = await _creatureService.GetImageFileAsync(model);

            _logger.LogInformation("Creature ({Type}, {Age}) was requested.", model.Type, model.Age);

            if (creature is null)
            {
                _logger.LogWarning("Creature ({Type}, {Age}) not found.", model.Type, model.Age);
                return NotFound();
            }

            return File(creature.FileContents, "image/png");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while trying to get the creature ({Type}, {Age}).", model.Type,
                model.Age);
            throw;
        }
    }
}