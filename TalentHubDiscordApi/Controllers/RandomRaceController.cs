// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;
using MyFabulousCreatures.Infrastructure;

namespace MyFabulousCreatures.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class RandomRaceController(ICreatureFactoryService creatureFactoryService)
    : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var raceId = creatureFactoryService.GetRandomRaceId();
        return Ok(raceId);
    }
}