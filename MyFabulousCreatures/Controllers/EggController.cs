// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;
using MyFabulousCreatures.Models;
using MyFabulousCreatures.Services;

namespace MyFabulousCreatures.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public sealed class EggController
    : ControllerBase
{
    private readonly IStaticFileService<Egg> _eggService;
    private readonly ILogger<EggController> _logger;

    public EggController(
        ILogger<EggController> logger,
        IStaticFileService<Egg> eggService)
    {
        _logger = logger;
        _eggService = eggService;
    }

    [HttpGet]
    public async Task<IActionResult> GetEggAsync([FromQuery] string creatureType, int creatureAge)
    {
        var egg = await _eggService.GetImageFileAsync(new Egg(creatureType, creatureAge));

        _logger.LogInformation("Egg ({}, {}) was requested.", creatureType, creatureAge);

        if (egg is null) return NotFound();

        return File(egg.FileContents, "image/png");
    }
}