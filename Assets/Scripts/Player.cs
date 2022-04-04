using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Animator playerAnimator;
    [SerializeField] private SpriteRenderer sprRend;
    [SerializeField] private bool JustSat = false;

    private float speedModifier;

    //This next public pool will be used in the Interactable Script.
    [SerializeField] public bool FreezeMovement;


    [SerializeField] public GameObject[] Evidence;
    
    void Update()
    {
        if(FreezeMovement == true)
        {
            speedModifier = 0f;
        } else
        {
            speedModifier = 3f;
        }
        
        
        float walkSpeedLeftRight = Input.GetAxisRaw("Horizontal") * speedModifier;
        float walkSpeedUpDown = Input.GetAxisRaw("Vertical") * speedModifier;

        transform.position += new Vector3(walkSpeedLeftRight * Time.deltaTime, walkSpeedUpDown * Time.deltaTime, 0);

        if(walkSpeedLeftRight == 0 && walkSpeedUpDown == 0)
        {
            Idle();
        }
        else
        {
            NotIdle(walkSpeedLeftRight);
        }
    }

    private void Idle()
    {
        if(JustSat == false)
        {
            playerAnimator.Play("Deteggtive-Idle");
            JustSat = true;
        }
        else
        {
            playerAnimator.Play("Deteggtive-Sit");
        }
        //In this code I'm trying to make sure the idle animation in which the player sits
        //Happens once, then the Sit animation continues.
        
        
    }

    private void NotIdle(float move)
    {
        JustSat = false;
        playerAnimator.Play("Deteggtive-Walk");

        if(move > 0)
        {
            sprRend.flipX = false;
        } 
        else if (move < 0) 
        {
            sprRend.flipX = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.CompareTag(tag);
        { }
    }
}
