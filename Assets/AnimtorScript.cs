using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimtorScript : MonoBehaviour
{
    private Animator playerAnimator;


    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right") || Input.GetKey("left"))
        {
            playerAnimator.SetBool("IsWalking", true);
        }
        if (Input.GetKeyUp("right") || Input.GetKeyUp("left"))
        {
            playerAnimator.SetBool("IsWalking", false);
        }
        if (Input.GetKey("right"))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

    }
}
