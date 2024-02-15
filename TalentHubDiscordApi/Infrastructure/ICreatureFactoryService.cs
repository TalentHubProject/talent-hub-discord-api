// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;

namespace MyFabulousCreatures.Infrastructure;

public interface ICreatureFactoryService
{
    Task<FileContentResult> CreateCreatureAsync(int level, int raceId);
    int GetRandomRaceId();
}