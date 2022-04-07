using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objects : Interactable
{
    public GameObject[] CollectedEvidence;
    public string Description;

    public override void Start()
    {
        Text InteractedWith = UIText.GetComponent<Text>();
        InteractedWith.text = Description;
    }

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        CollectedEvidence[0].SetActive(true);
        CollectedEvidence[1].SetActive(true);
        CollectedEvidence[2].SetActive(true);
    }
}
