using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerQuest : MonoBehaviour
{
    public List<Quest> quests = new List<Quest>();
    public void Update()
    {
        for (int i = 0; i < quests.Count; i++)
        {
            if (quests[i].goal.IsReached())
            {
                quests[i].Complete();
            }
        }
    }
}
