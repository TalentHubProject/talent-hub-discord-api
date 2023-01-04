// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

namespace MyFabulousCreatures.Models;

public class Creature
{
    protected Creature(
        int type,
        int age)
    {
        Type = type;
        Age = age;
    }

    public int Type { get; init; }
    public int Age { get; init; }

    public void Deconstruct(
        out int type,
        out int age)
    {
        type = Type;
        age = Age;
    }
}