using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{

    private float x;
    private float z;
    private bool rotateX;
    private float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {

        this.transform.parent = GameObject.Find("BackCamera").transform;
        this.transform.localPosition = new Vector3(0, 0, 0);

        this.transform.localRotation = new Quaternion(0,0,0,0);

        x = 0.0f;
        z = 0.0f;
        rotateX = true;
        rotationSpeed = 75.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rotateX == true)
        {
            x += Time.deltaTime * rotationSpeed;

            if (x > 360.0f)
            {
                x = 0.0f;
                rotateX = false;
            }
        }
        else
        {
            z += Time.deltaTime * rotationSpeed;

            if (z > 360.0f)
            {
                z = 0.0f;
                rotateX = true;
            }
        }

        transform.localRotation = Quaternion.Euler(x, 0, z);
    }
}
