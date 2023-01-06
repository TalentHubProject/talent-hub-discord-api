// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

namespace MyFabulousCreatures.Services.Assets.Decorator;

public class CreatureImagePathDecorator
    : PathDecorator
{
    private readonly int _age;
    private readonly int _creatureId;

    public CreatureImagePathDecorator(
        string path,
        int creatureId,
        int age)
        : base(path)
    {
        _creatureId = creatureId;
        _age = age > 3 
            ? 3 
            : age;
    }

    public override string GetPath()
    {
        return $"{Path}/Creature/{_creatureId}/creature_{_age}.png";
    }
}