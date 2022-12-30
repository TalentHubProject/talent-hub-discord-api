// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;

namespace MyFabulousCreatures.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public sealed class EggController
    : ControllerBase
{
    private readonly IWebHostEnvironment _environment;
    private readonly ILogger<EggController> _logger;
    
    public EggController(
        IWebHostEnvironment environment,
        ILogger<EggController> logger)
    {
        _environment = environment;
        _logger = logger;
    }

    [HttpGet()]
    public async Task<IActionResult> GetEggAsync()
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Assets/Egg", "oeuf.png");

        _logger.LogInformation("Filepath: {0}", filePath);
        
        if (!System.IO.File.Exists(filePath)) return NotFound();

        var fileByte = await System.IO.File.ReadAllBytesAsync(filePath);

        return File(fileByte, "image/png");
    }
}