using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCode : MonoBehaviour
{
    public Vector2 scr;
    public Vector2 size;

    void OnGUI()
    {
        //  GUI.Box(new Rect(0, 0, 100, 100),"");
        if(scr.x != Screen.width / 19)
        {
            scr.x = Screen.width / 16;
            scr.y = Screen.height / 9;
        }
        
        // GUI type/Pos/Start x,y/Size x,y/content
        for (int x = 0; x < 17; x++)
        {
            for (int y = 0; y <10; y++)
            {
                GUI.Box(new Rect(0, 0, scr.x * size.x, scr.y * size.y), "");
            }
        }


    }
}
