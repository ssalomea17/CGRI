using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class move_target : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    private bool objectTaken = false;
    private float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
            Vector3 mouse = Input.mousePosition;
            this.transform.localPosition = new Vector3(Math.Max(0, mouse.x),  mouse.y, 50);
            x = mouse.x;
            y = mouse.y;
            z = mouse.z;
        }
        
    }
}
