// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using System.ComponentModel.DataAnnotations;

namespace MyFabulousCreatures.Models;

/// <summary>
///     Represents an egg.
/// </summary>
/// <param name="Type">The type of the egg.</param>
/// <param name="Cracks">The number of cracks on the egg.</param>
public record Egg(string Type, [Range(0, 4)] int Cracks = 0);