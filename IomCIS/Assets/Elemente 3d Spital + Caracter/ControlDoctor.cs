using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDoctor : MonoBehaviour
{
     public float speed = 10f;
    private Rigidbody rb;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            // Link the "horizontal" parameter in the animator to the player's horizontal input
            anim.SetBool("walk", true);
        }
        if (!Input.GetKey("w"))
        {
            // Link the "horizontal" parameter in the animator to the player's horizontal input
            anim.SetBool("walk", false);
        }


        if (Input.GetKey("a"))
        {
            // Link the "horizontal" parameter in the animator to the player's horizontal input
            anim.SetBool("turnLeft", true);
        }
        if (!Input.GetKey("a"))
        {
            // Link the "horizontal" parameter in the animator to the player's horizontal input
            anim.SetBool("turnLeft", false);
        }


        if (Input.GetKey("d"))
        {
            // Link the "horizontal" parameter in the animator to the player's horizontal input
            anim.SetBool("turnRight", true);
        }
        if (!Input.GetKey("d"))
        {
            // Link the "horizontal" parameter in the animator to the player's horizontal input
            anim.SetBool("turnRight", false);
        }


        if (Input.GetKey("s"))
        {
            // Link the "horizontal" parameter in the animator to the player's horizontal input
            anim.SetBool("backward", true);
        }
        if (!Input.GetKey("s"))
        {
            // Link the "horizontal" parameter in the animator to the player's horizontal input
            anim.SetBool("backward", false);
        }

        if (Input.GetKey("q"))
        {
            // Link the "horizontal" parameter in the animator to the player's horizontal input
            anim.SetBool("wakingup", true);
        }
        if (!Input.GetKey("q"))
        {
            // Link the "horizontal" parameter in the animator to the player's horizontal input
            anim.SetBool("wakingup", false);
        }


        if (Input.GetKey("z"))
        {
            // Link the "horizontal" parameter in the animator to the player's horizontal input
            anim.SetBool("walinkdown", true);
        }
        if (!Input.GetKey("z"))
        {
            // Link the "horizontal" parameter in the animator to the player's horizontal input
            anim.SetBool("walinkdown", false);
        }
    }
}
