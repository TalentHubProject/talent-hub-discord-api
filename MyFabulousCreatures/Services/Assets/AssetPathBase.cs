// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

namespace MyFabulousCreatures.Services.Assets;

public abstract class AssetPathBase
{
    protected string Path;

    public AssetPathBase(string path)
    {
        Path = path;
    }

    public abstract string GetPath();
}