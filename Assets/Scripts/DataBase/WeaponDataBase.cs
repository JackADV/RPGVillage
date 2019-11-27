using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class WeaponDataBase : MonoBehaviour
{
    public int id;
    public int stats;
    public string type;

    IEnumerator WeaponInformationSet(int weaponStats, string weaponType, int idNumber)
    {
        string weaponInformationURL = "http://localhost/loginproject/weapons.php";
        WWWForm form = new WWWForm();
        form.AddField("type", weaponType);
        form.AddField("id", idNumber);
        form.AddField("stats", weaponStats);
        UnityWebRequest webRequest = UnityWebRequest.Post(weaponInformationURL, form);
        yield return webRequest.SendWebRequest();
    }
    IEnumerator WeaponInformationGet(int id)
    {
        string weaponInformationURL = "http://localhost/loginproject/weaponsGet.php";
        WWWForm form = new WWWForm();
        form.AddField("id", id);
        UnityWebRequest webRequest = UnityWebRequest.Post(weaponInformationURL, form);
        yield return webRequest.SendWebRequest();
        //split and parse string to locations
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad4))
        {
            StartCoroutine(WeaponInformationSet(stats, type,id));
        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            StartCoroutine(WeaponInformationGet(id));
        }
    }
}
