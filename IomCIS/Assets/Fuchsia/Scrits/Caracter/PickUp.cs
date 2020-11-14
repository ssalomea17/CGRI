using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform theDest;
    private Boolean objectTaken =false;
    private float time = 0;

    public void Update()
    {

        if (Input.GetKey("f"))
        {
            if (Time.time > time + 0.5)
            {
                objectTaken = !objectTaken;
                time = Time.time;
            }
        }
        
        if (objectTaken)
        {
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = theDest.position;
            this.transform.parent = GameObject.Find("siringa").transform;
        }
        else
        {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
        }
       
    }
}
