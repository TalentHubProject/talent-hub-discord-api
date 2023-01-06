// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

namespace MyFabulousCreatures.Services.Assets.Decorator;

public class EggImagePathDecorator
    : PathDecorator
{
    private readonly int _cracks;
    private readonly int _id;

    public EggImagePathDecorator(
        string path,
        int id,
        int cracks)
        : base(path)
    {
        _id = id;
        _cracks = cracks > 3 
            ? 3 
            : cracks;
    }

    public override string GetPath()
    {
        return $"{Path}/{_id}/egg_{_cracks}.png";
    }
}