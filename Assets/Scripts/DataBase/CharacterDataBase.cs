using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CharacterDataBase : MonoBehaviour
{
    public int id, level, strength, agility, intelligence, health;
    public string characterName;


    IEnumerator CharacterInformation(int charId, int charLevel, int charStrength, int charAgility, int charIntelligene, int charHealth, string charName)
    {
        string characterInformationURL = "http://localhost/loginproject/weapons.php";
        WWWForm form = new WWWForm();
        form.AddField("int", charId);
        form.AddField("int", charLevel);
        form.AddField("int", charStrength);
        form.AddField("int", charAgility);
        form.AddField("int", charIntelligene);
        form.AddField("int", charHealth);
        form.AddField("string", charName);
        UnityWebRequest webRequest = UnityWebRequest.Post(characterInformationURL, form);
        yield return webRequest.SendWebRequest();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            StartCoroutine(CharacterInformation(id,level,strength,agility,intelligence,health,characterName));
        }
    }
}
