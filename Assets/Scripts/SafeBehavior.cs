using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeBehavior : Objects
{
    private bool IsSafeUnlocked = false;
    
    public void UnlockSafe()
    {
        IsSafeUnlocked = true;
    }

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        if(IsSafeUnlocked == true)
        {
            Debug.Log("Let's goooooooooooo");
        }
        else
        {
            base.OnTriggerEnter2D(collision);
        }
        
    }
}
