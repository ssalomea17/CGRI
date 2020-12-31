using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations.Rigging;

public class PickUp : MonoBehaviour
{
    public Rig rig;
    public Transform theDest;
    private Boolean objectTaken =false;
    private float time = 0;
    public float x = 0.07f;
    public float y;
    public float z;


    public float rw;
    public float rx;
    public float ry;
    public float rz;

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
            //this.transform.position = theDest.position;
            this.transform.parent = GameObject.Find("mixamorig:RightHandThumb2").transform;
            this.transform.localPosition = new Vector3(0.12f, 0.15f, z);
            this.transform.localRotation = new Quaternion(1, ry, rz, rw);

            if(rig.weight < 0.99f)
                rig.weight += 0.01f;
        }
        else
        {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            if (rig.weight > 0.01f)
                rig.weight -= 0.01f;
        }
       
    }
}
