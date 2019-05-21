using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Allow us to interact with UI elements

//this script can be found in the Component section under the option Intro PRG/Player/Health
namespace QuarterHeart{

public class Health : MonoBehaviour
{   [Header("Player Stats") ]
    //[Header("Player Stats")]
    public float MaxHealth;
    //public maxHealth
    public float curHealth;
    //public curHealth
    [Header("Heart Slots")] // Set up image slots to auto set up according to the amount of slots needed spawn them in
    //[Header("Heart Slots")]
    public Image[] heartSlots = new Image[3]; 
    //Canvas Image heartSlots array
    public Sprite[] hearts = new Sprite[5];
    //Sprite hearts array
    private float healthPerSection;
    //private percent healthPerSection
    #region Start
    private void Start()
    {
        UpdateHearts();
    }
           // Run UpdateHearts
    #endregion
	#region Update 
        private void Update()
        {
            //index variable starting at 0 for slot checks
            int i = 0;
             //foreach Image slot in heartSlots
            foreach (Image slot in heartSlots)
            {
                if (curHealth >= (healthPerSection * 4)+ (healthPerSection * 4)*i)
                {   
                    heartSlots[i].sprite = hearts[0];
                    //Set heart to 4/4
                }
                 //else if curHealth is greater or equal to 3/4 for this slot amount
                else if (curHealth >= (healthPerSection * 3)+ (healthPerSection * 4)*i)
                {
                    heartSlots[i].sprite = hearts[1];
                    //Set Heart to 3/4
                }
                else if (curHealth >= (healthPerSection * 2)+ (healthPerSection * 4)*i)
                {
                    heartSlots[i].sprite = hearts[2];
                    //else if curHealth is greater or equal to 2/4 for this slot amount
                //Set Heart to 2/4  
                }
                else if (curHealth >= (healthPerSection * 1)+ (healthPerSection * 4)*i)
                {
                    heartSlots[i].sprite = hearts[3];
                      //else if curHealth is greater or equal to 1/4 for this slot amount
                //Set Heart to 1/4
                }       
                 //else
                else 
                {
                    heartSlots[i].sprite = hearts[4];
                //we are empty
                }
            
            //after checking this slot increase slot index
            i++;
        }
        }
      
      
	#endregion
    #region UpdateHearts
    void UpdateHearts()
    {
            healthPerSection = MaxHealth / (heartSlots.Length * 4);
            //calculate the health points per heart section
    }
       
    #endregion
}   
}
