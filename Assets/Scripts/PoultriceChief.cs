using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoultriceChief : NPC
{
    public virtual void GlassEvidenceShownToChief()
    {
        UIText.GetComponent<Text>().text = Dialogue[1];
    }
}
