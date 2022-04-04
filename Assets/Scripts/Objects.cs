using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : Interactable
{
    public GameObject CollectedEvidence;

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);

    }
}
