﻿// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;

namespace MyFabulousCreatures.Services;

public class FileImageService
    : IFileImageService
{
    public async Task<FileContentResult> GetImageFileAsync()
    {
        return new FileContentResult(await File.ReadAllBytesAsync("wwwroot/images/creature.png"), "image/png");
    }
}