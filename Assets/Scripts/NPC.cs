using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : Interactable
{
    public string DialogueOne;
    public string[] Dialogue;

    //public GameObject EvidenceFolder;
    
    public override void Start()
    {
        Text InteractedWith = UIText.GetComponent<Text>();
        InteractedWith.text = Dialogue[0];
    }

    

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        //EvidenceFolder.SetActive(true);
    }

    public override void OnTriggerExit2D(Collider2D collision)
    {
        base.OnTriggerExit2D(collision);
        //EvidenceFolder.SetActive(false);
    }
}
