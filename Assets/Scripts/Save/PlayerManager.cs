using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int level;
    public new string name;
    public float maxHp, curHp;
    public LinearhealthBar.Health health;
    public CheckPoint checkpoint;
    public float x, y, z;




    public void SavePlayer()
    {
        curHp = health.curHealth;
        maxHp = health.maxHealth;
        x = checkpoint.curCheckPoint.x;
        y = checkpoint.curCheckPoint.y;
        z = checkpoint.curCheckPoint.z;
        Save.SavePlayerData(this);
    }
    public void LoadPlayer()
    {
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
}
