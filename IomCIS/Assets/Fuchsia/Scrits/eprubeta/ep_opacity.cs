using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ep_opacity : MonoBehaviour
{


    bool changing_started = false;
    // Start is called before the first frame update
    void Start()
    {

        gameObject.GetComponent<Renderer>().enabled = false;
        //gameObject.transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (!changing_started && Input.GetKey("c"))
        {
            //gameObject.transform.localScale += new Vector3(0, 50, 0); ;
            gameObject.GetComponent<Renderer>().enabled = true;
            changing_started = !changing_started;
        } 

        if (changing_started && gameObject.transform.localScale.y < 0.002)
        {
            gameObject.transform.localScale += new Vector3(0, 0.0005f, 0);
            print(gameObject.transform.localScale.y);
        }
        

    }
}
