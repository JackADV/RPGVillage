using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CustomisationSave
{
    public int skinIndex;
    public int hairIndex, mouthIndex, eyesIndex, clothesIndex, armourIndex;
    public string characterName;
    public string charClass;
    public string charRace;
    public int[] stats = new int[6];


    public CustomisationSave(CustomisationSet player)
    {
        skinIndex = player.skinIndex;
        charClass = player.charClass.ToString();
        charRace = player.charRace.ToString();
        hairIndex = player.hairIndex;
        eyesIndex = player.eyesIndex;
        mouthIndex = player.mouthIndex;
        clothesIndex = player.clothesIndex;
        armourIndex = player.armourIndex;

        for (int i = 0; i < 6; i++)
        {
            stats[i] = (player.stats[i] + player.tempStats[i]);
        }

    }


}
