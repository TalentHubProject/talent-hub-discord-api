// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

namespace MyFabulousCreatures.Services.Assets;

public abstract class AssetPathWithExtension
    : AssetPath
{
    protected AssetPath AssetPath;

    protected AssetPathWithExtension(AssetPath assetPath)
    {
        AssetPath = assetPath;
    }

    protected AssetPath Extension { get; set; }
}