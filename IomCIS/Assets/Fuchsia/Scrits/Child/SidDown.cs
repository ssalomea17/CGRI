using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SidDown : MonoBehaviour
{

    public String Leter;
    private float time = 0;

    public Transform leftUpLeg;
    public Transform rightUpLeg;

    public Transform theDest;

    BoxCollider m_Collider;

    // Start is called before the first frame update
    void Start()
    {
        m_Collider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Leter))
        {
            if (Time.time > time + 0.5)
            {
                this.transform.parent = theDest;
                this.transform.localPosition = new Vector3(0, 0.1000004f, 0);
                this.transform.rotation = new Quaternion(0,0,0,0);                

                // Dampen towards the target rotation
                leftUpLeg.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
                rightUpLeg.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);





                time = Time.time;
                m_Collider.center = new Vector3(0.0f, 0.1f, 0.0f);


            }
        }

        
    }
}
