// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

namespace MyFabulousCreatures.Services.Assets.Decorator;

public class EggAssetPathDecorator
    : AssetPathWithExtension
{
    public EggAssetPathDecorator(
        AssetPath assetPath)
        : base(assetPath)
    {
        Extension = assetPath;
    }

    public override string GetPath()
    {
        return $"{AssetPath.GetPath()}/Eggs/";
    }
}