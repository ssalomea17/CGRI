using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Transform theDest1;
    public Transform theDest2;
    private bool objectTaken = false;
    private float time = 0;

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
            this.transform.parent = GameObject.Find("FrontCamera").transform;
            this.transform.localPosition = new Vector3(0, 0, 0);
            
        }
        else
        {

            this.transform.parent = GameObject.Find("BackCamera").transform;
            this.transform.localPosition = new Vector3(0, 0, 0);
        }

        this.transform.rotation = this.transform.parent.rotation;
    }
}
