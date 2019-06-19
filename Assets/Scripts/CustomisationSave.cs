using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CustomisationSave
{
    public int skinIndex; // All available skin pieces
    public int hairIndex, mouthIndex, eyesIndex, clothesIndex, armourIndex; // All available customization pieces for each catorgary
    public string characterName; // A list of characters that can be used as a name
    public string charClass; // a list of all the character classes
    public string charRace; // a list of all the character races
    public int[] stats = new int[6]; // Array containing 6 player stats
    

    public CustomisationSave(CustomisationSet player)
    {
        skinIndex = player.skinIndex;    // Things to save, all meshes the player has selected to use on their character
        hairIndex = player.hairIndex;
        eyesIndex = player.eyesIndex;
        mouthIndex = player.mouthIndex;
        clothesIndex = player.clothesIndex;
        armourIndex = player.armourIndex;
        characterName = player.characterName; // The players name
        charClass = player.charClass.ToString(); // The players class
        charRace = player.charRace.ToString(); // The players race
        for (int i = 0; i < 6; i++)
        {
            stats[i] = (player.stats[i] + player.tempStats[i]); // a loop to cycle through all of the stats asscioated with each class that the player selects
        }

    }


}
