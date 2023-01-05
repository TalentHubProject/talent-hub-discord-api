// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;
using Remora.Results;

namespace MyFabulousCreatures.Services;

public class StaticFileService
    : IStaticFileService
{
    private static readonly string AssetsPath = Path.Combine(Directory.GetCurrentDirectory(), "Assets");

    public async Task<FileContentResult?> GetImageFileAsync(string fileName)
    {
        if (!File.Exists(Path.Combine(AssetsPath, fileName)))
            return null;

        var file = await File.ReadAllBytesAsync(Path.Combine(AssetsPath, fileName));
        return new FileContentResult(file, "image/png");
    }
}