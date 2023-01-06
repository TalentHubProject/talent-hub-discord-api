// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

namespace MyFabulousCreatures.Services.Assets;

public abstract class PathDecorator
    : AssetPathBase
{
    public PathDecorator(string path)
        : base(DecoratedPath.GetPath())
    {
    }

    protected static AssetPathBase DecoratedPath { get; }
}