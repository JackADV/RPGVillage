using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CharacterDataBase : MonoBehaviour
{
    public int level, strength, agility, intelligence, race, eyes, mouth, clothes, armour, hair, charClass, skin;
    public string userName, characterName;


    IEnumerator CharacterInformation(int charLevel, int charStrength, int charAgility, int charIntelligene, 
        int charRace, int charEyes, int charMouth, int charClothes, int charArmour, int charHair, string charName, string charUsername)
    {
        string characterInformationURL = "http://localhost/loginproject/weapons.php";
        WWWForm form = new WWWForm();
        form.AddField("int", charLevel);
        form.AddField("int", charStrength);
        form.AddField("int", charAgility);
        form.AddField("int", charIntelligene);
        form.AddField("int", charStrength);
        form.AddField("int", charRace);
        form.AddField("int", charEyes);
        form.AddField("int", charMouth);
        form.AddField("int", charClothes);
        form.AddField("int", charMouth);
        form.AddField("int", charArmour);
        form.AddField("int", charHair);
        form.AddField("string", charName);
        form.AddField("string", charUsername);
        UnityWebRequest webRequest = UnityWebRequest.Post(characterInformationURL, form);
        yield return webRequest.SendWebRequest();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            StartCoroutine(CharacterInformation(level, strength, agility, intelligence, race, eyes, mouth, clothes, armour, hair, userName, characterName));
        }
    }
}
