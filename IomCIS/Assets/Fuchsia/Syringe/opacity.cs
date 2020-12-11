using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opacity : MonoBehaviour
{
    private bool boo=false;
    private float time = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Renderer>().enabled = false;

        if (Input.GetKey("c"))
        {
            if (Time.time > time + 0.5)
            {
                time = Time.time;
                boo = !boo;
            }
        }

        if (boo)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
