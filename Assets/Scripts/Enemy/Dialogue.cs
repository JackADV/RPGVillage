using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public bool showDlg;
    public Vector2 scr;
    public string[] dlgText;
    public int index, optionsIndex;
	
	// Update is called once per frame
	void OnGUI ()
    {
        if (showDlg)
        {
            if(scr.x != Screen.width/16 || scr.y != Screen.height / 9)
            {
                scr.x = Screen.width / 16;
                scr.y = Screen.height / 9;
            }
            GUI.Box(new Rect(0,6*scr.y,Screen.width,3*scr.y),dlgText[index]);

            // !index+1 >= dlgText.Length
            // !index >= dlgText.Length-1
            // index < dlgText.Length
            if (!(index + 1 >= dlgText.Length || index == optionsIndex))
            {
                if(GUI.Button(new Rect(scr.x*15,scr.y*8.5f,scr.x,scr.x*0.5f), "Next"))
                {
                    index++;
                }
            }
            else if (index == optionsIndex)
            {
                if (GUI.Button(new Rect(13 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Accept"))
                {
                    index++;
                }
                if (GUI.Button(new Rect(14 * scr.x, 8.5f * scr.y, scr.x, 0.5f * scr.y), "Decline"))
                    {
                    index = dlgText.Length - 1;
                    }
            }
            else
            {
                if (GUI.Button(new Rect(scr.x * 15, scr.y * 8.5f, scr.x, scr.x * 0.5f), "Bye"))
                {
                    index = 0;
                    showDlg = false;
                    Movement.canMove = true;
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    // Enable camera and player movement
                }
            }
                

        }

    }
}
