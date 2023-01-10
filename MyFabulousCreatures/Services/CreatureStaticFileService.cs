// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;
using MyFabulousCreatures.Models;
using MyFabulousCreatures.Services.Assets;
using MyFabulousCreatures.Services.Assets.Decorator;

namespace MyFabulousCreatures.Services;

public class CreatureStaticFileService
    : IStaticFileService<Creature>
{
    public async Task<FileContentResult?> GetImageFileAsync(Creature model)
    {
        AssetPath path = new AssetPathBase();
        path = new CreatureAssetPathDecorator(path);

        var creaturePath = $"{path.GetPath()}/{model.Type}/creature_{model.Age}.png";

        if (!File.Exists(creaturePath)) return null;

        var file = await File.ReadAllBytesAsync(creaturePath);
        return new FileContentResult(file, "image/png");
    }
}