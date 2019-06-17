using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;


public static class SaveCustomSet
{
    public static void CustomisationSet(CustomisationSet player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/CustomisationSet";
        FileStream stream = new FileStream(path, FileMode.Create);
        CustomisationSave customSave = new CustomisationSave(player);
        formatter.Serialize(stream, customSave);
        stream.Close();

    }
    public static CustomisationSave LoadCustomSet()
    {
        string path = Application.persistentDataPath + "/CustomisationSet";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            CustomisationSave customSave = formatter.Deserialize(stream) as CustomisationSave;

        
        stream.Close();
        return customSave;
    }
        else
        {
            Debug.Log("Couldn't find file to load" + path);
            return null;

        }
        
    }
}
