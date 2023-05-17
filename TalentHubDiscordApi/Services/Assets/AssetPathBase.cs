// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

namespace MyFabulousCreatures.Services.Assets;

public class AssetPathBase
    : AssetPath
{
    public override string GetPath()
    {
        return System.IO.Path.Combine(
            Directory.GetCurrentDirectory(),
            "Assets");
    }
}