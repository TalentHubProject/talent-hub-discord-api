// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

namespace MyFabulousCreatures.Services.Assets.Decorator;

public class CreatureAssetPathDecorator
    : AssetPathWithExtension
{
    private readonly int _creatureAge;
    private readonly string _creatureType;

    public CreatureAssetPathDecorator(
        AssetPath assetPath,
        string creatureType,
        int creatureAge)
        : base (assetPath)
    {
        Extension = assetPath;
        
        _creatureType = creatureType;
        _creatureAge = creatureAge;
    }

    public override string GetPath()
    {
        return $"{AssetPath.GetPath()}/Creatures/";
    }
}