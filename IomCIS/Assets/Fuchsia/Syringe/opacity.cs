using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class opacity : MonoBehaviour
{

    public Text text;
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
            
        }
        if (Time.time > time + 0.5)
        {
            time = Time.time;
            //text.text = string.Format("Not Colision");
        }

        if (boo)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            //gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "LeftForeArm")
        {
            boo = true;
            
        }
        text.text = other.gameObject.name;
    }
}
