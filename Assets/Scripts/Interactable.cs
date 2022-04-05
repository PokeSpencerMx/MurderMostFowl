using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public string Name;
    //public string Description;
    public GameObject TextBox;
    public GameObject UIText;
    public GameObject Player;
    
    
    
    // Start is called before the first frame update
    public virtual void Start()
    {
        

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void OnInteract()
    {
        
    }

    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        TextBox.SetActive(true);
        
    }

    public virtual void OnTriggerExit2D(Collider2D collision)
    {
        TextBox.SetActive(false);
    }

    


}
