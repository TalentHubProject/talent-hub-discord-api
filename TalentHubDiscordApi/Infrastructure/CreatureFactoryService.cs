// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;

namespace MyFabulousCreatures.Infrastructure;

public class CreatureFactoryService(
    IWebHostEnvironment env,
    ILogger<CreatureFactoryService> logger)
    : ICreatureFactoryService
{
    public async Task<FileContentResult> CreateCreatureAsync(int level, int raceId)
    {
        var imagePath = GenerateImagePath(level, raceId);
        if (File.Exists(imagePath))
        {
            var imageBytes = await File.ReadAllBytesAsync(imagePath);
            return new FileContentResult(imageBytes, "image/png");
        }

        logger.LogWarning($"Image not found for level {level} and raceId {raceId}.");
        throw new FileNotFoundException("Image not found.");
    }

    private string GenerateImagePath(int level, int raceId)
    {
        var imageIndex = level / 5;
        const int maxEggIndex = 3; 
        const int minCreatureIndex = 1; 
        const int maxCreatureIndex = 3; 
    
        var type = imageIndex <= maxEggIndex ? "Egg" : "Creature";
    
        if (type == "Creature")
        {
            imageIndex = Math.Max(minCreatureIndex, imageIndex - maxEggIndex);
            imageIndex = Math.Min(imageIndex, maxCreatureIndex); 
        }
    
        var raceName = RaceIdToName(raceId); 
        var folderName = type == "Egg" ? "Eggs" : "Creatures";
        var imageName = $"{type.ToLower()}_{imageIndex}.png";
    
        return Path.Combine("Assets", folderName, raceName, imageName);
    }

    private static string RaceIdToName(int raceId)
    {
        return raceId switch
        {
            1 => "Cat",
            2 => "Cow",
            3 => "Mouse",
            4 => "Snake",
            _ => throw new ArgumentOutOfRangeException(nameof(raceId), "Race ID is not recognized.")
        };
    }
}