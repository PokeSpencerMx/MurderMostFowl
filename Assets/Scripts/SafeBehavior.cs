using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeBehavior : Objects
{
    private bool IsSafeUnlocked = false;

    public GameObject NewTextBox;

    public GameObject[] ScheduleEvidence;
    
    public void UnlockSafe()
    {
        IsSafeUnlocked = true;
    }

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        if(IsSafeUnlocked == true)
        {
            NewTextBox.SetActive(true);
            ScheduleEvidence[0].SetActive(true);
            ScheduleEvidence[1].SetActive(true);
            ScheduleEvidence[2].SetActive(true);
        }
        else
        {
            base.OnTriggerEnter2D(collision);
        }
        
    }

    public override void OnTriggerExit2D(Collider2D collision)
    {
        base.OnTriggerExit2D(collision);
        NewTextBox.SetActive(false);
    }
}
