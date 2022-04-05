using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : Interactable
{
    public string DialogueOne;
    public string[] Dialogue;
    
    public override void Start()
    {
        Text InteractedWith = UIText.GetComponent<Text>();
        InteractedWith.text = Dialogue[0];
    }

    public void PresentedTheRightEvidence()
    {
        Debug.Log(Dialogue[1]);
        UIText.GetComponent<Text>().text = Dialogue[1];
    }
}
