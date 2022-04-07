using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Birt : NPC
{
    public virtual void ShowScheduleToBirt()
    {
        UIText.GetComponent<Text>().text = Dialogue[1];
    }
}
