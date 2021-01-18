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
        //gameObject.GetComponent<Renderer>().enabled = false;

       
        if (Time.time > time + 0.5)
        {
            if (Input.GetKey("c"))
            {
                boo = !boo;
            }
            time = Time.time;
            //text.text = string.Format("Not Colision");
        }
        //print(gameObject.transform.localScale.y);
        if (boo && gameObject.transform.localScale.y < 1f)
        {
            //print("Loading");
            gameObject.GetComponent<Renderer>().enabled = true;
            gameObject.transform.localScale += new Vector3(0, 0.005f, 0);
        }
        else if(!boo && gameObject.transform.localScale.y > 0.0005f)
        {
            //print("un Loading");
            //gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.transform.localScale -= new Vector3(0, 0.005f, 0);
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
