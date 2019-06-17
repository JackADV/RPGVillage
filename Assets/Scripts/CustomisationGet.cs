using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
//you will need to change Scenes
public class CustomisationGet : MonoBehaviour
{
    [Header("Character")]
    //[Header("Character")]
    //public variable for the Skinned Mesh Renderer which is our character reference
    public Renderer character;
    public TextMeshProUGUI CharName;
    public TextMeshProUGUI CharRace;
    public TextMeshProUGUI[] stats;
    #region Start
    public void Start()
    {
        //our character reference connected to the Skinned Mesh Renderer via finding the Mesh
        character = GameObject.FindGameObjectWithTag
            ("PlayerMesh").GetComponent<SkinnedMeshRenderer>();
        //Run the function LoadTexture
        LoadTexture();
    }
    #endregion

    #region LoadTexture Function
    public void LoadTexture()
    {
        CustomisationSave data = SaveCustomSet.LoadCustomSet();
        SetTexture("Skin", data.skinIndex);
        SetTexture("Hair", data.hairIndex);
        SetTexture("Mouth", data.mouthIndex);
        SetTexture("Eyes", data.eyesIndex);
        SetTexture("Clothes", data.clothesIndex);
        SetTexture("Armour", data.armourIndex);
        this.gameObject.name = data.characterName;
        CharName.text = data.characterName;
        CharRace.text = data.charRace;
        for (int i = 0; i < 6; i++)
        {
            stats[i].text = data.stats[i].ToString();
        }
    }

    #endregion
    #region SetTexture
    void SetTexture(string type, int index)
    {
        //Create a function that is called SetTexture it should contain a string and int
        //the string is the name of the material we are editing, the int is the direction we are changing

        //we need variables that exist only within this function
        //these are int material index and Texture2D texture
        Texture2D tex = null;
        int matIndex = 0;
        //inside a switch statement that is swapped by the string name of our material

        switch (type)
        {
            //case skin
            case "Skin":
                //textures is our Resource.Load Character Skin save index we loaded in set as our Texture2D
                //material index element number is 1
                tex = Resources.Load("Character/Skin_" + index) as Texture2D;
                matIndex = 1;
                break;

            case "Hair":

                tex = Resources.Load("Character/Hair_" + index) as Texture2D;
                matIndex = 2;
                break;

            case "Mouth":

                tex = Resources.Load("Character/Mouth_" + index) as Texture2D;
                matIndex = 3;
                break;

            case "Eyes":

                tex = Resources.Load("Character/Eyes_" + index) as Texture2D;
                matIndex = 4;
                break;

            case "Clothes":

                tex = Resources.Load("Character/Clothes_" + index) as Texture2D;
                matIndex = 5;
                break;

            case "Armour":

                tex = Resources.Load("Character/Armour_" + index) as Texture2D;
                matIndex = 6;
                break;
                //break
                //now repeat for each material 
                //hair is 2
                //mouth is 3
                //eyes are 4
        }


        //Material array is equal to our characters material list
        Material[] mats = character.materials;
        //our material arrays current material index's main texture is equal to our texture arrays current index
        mats[matIndex].mainTexture = tex;
        //our characters materials are equal to the material array
        character.materials = mats;
    }

    #endregion
}
