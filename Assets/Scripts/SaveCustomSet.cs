using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;


public static class SaveCustomSet
{
    #region Custom Set player
    public static void CustomisationSet(CustomisationSet player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/CustomisationSet";
        FileStream stream = new FileStream(path, FileMode.Create);
        CustomisationSave customSave = new CustomisationSave(player);
        formatter.Serialize(stream, customSave);
        stream.Close();

    }
    #endregion
    #region Customer Save
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
            Debug.Log("Couldn't find file to load" + path); // A log to appear in the console
            return null;

        }
        
    }
    #endregion
}
