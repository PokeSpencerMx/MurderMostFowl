using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public string Name;
    public string Description;
    public GameObject TextBox;
    public GameObject UIText;
    public GameObject Player;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Text InteractedWith = UIText.GetComponent<Text>();
        InteractedWith.text = Description;

        
        
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
        if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.F) && Input.GetKey(KeyCode.E))
        {
            Debug.Log("Safe appears!");
        }
    }

    public virtual void OnTriggerExit2D(Collider2D collision)
    {
        TextBox.SetActive(false);
    }


}
