using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

    [Header("Player Stats")]

    public string[] stats;
    public int[] statDats;
    public string playerName;
    public int level;
    public float maxHp, maxStam, maxMana, maxExp;
    public float curHp, curStam, curMana, curExp;

    [Header("Game Reference")]
    public Slider hpBar;
    public Slider stamBar, manaBar, expBar;
    
    void Start ()
    {
		
	}
	
	
	//void Update ()
 //   {
 //       hpBar.value = Mathf.Clamp01(curHp / maxHp);
 //       stamBar.value = Mathf.Clamp01(curStam / maxStam);
 //       manaBar.value = Mathf.Clamp01(curMana / maxMana);
 //       // expBar.value = Mathf.Clamp01(curExp / maxExp);
 //   }
}
