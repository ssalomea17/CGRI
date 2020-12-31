using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations.Rigging;

public class PickUp : MonoBehaviour
{
    private const bool V = false;
    public Rig rig;
    public Transform theDest;
    private Boolean objectTaken =false;
    public String Leter;
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

        if (Input.GetKey(Leter))
        {
            if (Time.time > time + 0.5)
            {
                objectTaken = !objectTaken;
                time = Time.time;
            }
        }
        
        if (objectTaken)
        {
            GetComponent<Rigidbody>().useGravity = V;
            //this.transform.position = theDest.position;
            //this.transform.parent = GameObject.Find("mixamorig:RightHandThumb2").transform;
            this.transform.parent = theDest;
            this.transform.localPosition = new Vector3(0.12f, 0.15f, z);
            this.transform.localRotation = new Quaternion(1, ry, rz, rw);

            if(rig.weight < 0.99f)
                rig.weight += 0.01f;
        }
        else
        {

            this.transform.parent = GameObject.Find("OriginalSyringePlace").transform;
            this.transform.localPosition = new Vector3(0f, -0.016f, 0f);
            this.transform.localRotation = new Quaternion(0f, 0f, 0f,0f);
            //GetComponent<Rigidbody>().useGravity = true;
            if (rig.weight > 0.01f)
                rig.weight -= 0.01f;
        }
       
    }
}
