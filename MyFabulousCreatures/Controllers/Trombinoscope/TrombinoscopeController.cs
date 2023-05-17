// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;

namespace MyFabulousCreatures.Controllers.Trombinoscope;

[ApiController]
[Route("/api/v1/[controller]")]
public class TrombinoscopeController
    : ControllerBase
{
    private readonly ILogger<TrombinoscopeController> _logger;

    public TrombinoscopeController(ILogger<TrombinoscopeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetShuffledTrombinoscopeAsync()
    {
        _logger.LogInformation("Trombinoscope was requested.");

        return Ok();
    }
}