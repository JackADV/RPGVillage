using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Varibles
    public int level;
    public new string name;
    public float maxHp, curHp;
    public LinearhealthBar.Health health;
    public CheckPoint checkpoint;
    public float x, y, z;
    #endregion


    #region Save Player
    public void SavePlayer()
    {
        // information that is to be saved
        curHp = health.curHealth; // players current health
        maxHp = health.maxHealth; // Players max health
        x = checkpoint.curCheckPoint.x; // Their current location
        y = checkpoint.curCheckPoint.y;
        z = checkpoint.curCheckPoint.z;
        Save.SavePlayerData(this); // Save this information
    }
    #endregion
    #region load Player
    public void LoadPlayer()
    {
        // All of the data that has been saved (see above) will be loaded
        DataToSave data = Save.LoadPlayerData();
        level = data.level;
        name = data.playerName;
        curHp = data.curHp;
        maxHp = data.maxHp;
        health.curHealth = curHp;
        health.maxHealth = maxHp;
        x = data.x;
        y = data.y;
        z = data.z;
        this.transform.position = new Vector3(x, y, z);

    }
    #endregion
}
