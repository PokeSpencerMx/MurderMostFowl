using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Henrietta : NPC
{
    private bool TalkingToHenrietta = false;

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        TalkingToHenrietta = true;
    }

    public override void OnTriggerExit2D(Collider2D collision)
    {
        base.OnTriggerExit2D(collision);
        TalkingToHenrietta = false;
    }

    public virtual void PresentedTheRightEvidence()
    {
        //Debug.Log(Dialogue[1]);
        UIText.GetComponent<Text>().text = Dialogue[1];
    }
}
