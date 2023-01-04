// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;
using MyFabulousCreatures.Services;

namespace MyFabulousCreatures.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public sealed class EggController
    : ControllerBase
{
    private readonly ILogger<EggController> _logger;
    private readonly IFileImageService _fileImageService;

    public EggController(
        ILogger<EggController> logger,
        IFileImageService fileImageService)
    {
        _logger = logger;
        _fileImageService = fileImageService;
    }

    [HttpGet]
    public async Task<IActionResult> GetEggAsync()
    {
        var egg = await _fileImageService.GetImageFileAsync("Egg/1/egg_1.png");
        
        if (egg is null)
        {
            return NotFound();
        }

        return File(egg.FileContents, "image/png");
    }
}