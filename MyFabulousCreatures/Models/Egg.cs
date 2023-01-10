// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using System.ComponentModel.DataAnnotations;

namespace MyFabulousCreatures.Models;

public record Egg(string CreatureType, [Range(0, 4)] int Cracks = 0);