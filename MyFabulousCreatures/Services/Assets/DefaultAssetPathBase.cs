// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

namespace MyFabulousCreatures.Services.Assets;

public class DefaultAssetPathBase
    : AssetPathBase
{
    public DefaultAssetPathBase(string path)
        : base(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Assets"))
    {
    }

    public override string GetPath()
    {
        return Path;
    }
}