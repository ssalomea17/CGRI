using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCamera : MonoBehaviour
{
    public Text t;
    private bool objectTaken = false;
    private float time = 0;

    float distValue=0;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
        {
            //minimap.orthographicSize++;
            t.text = Input.GetAxis("Mouse ScrollWheel").ToString();
            //distValue+= Input.GetAxis("Mouse ScrollWheel");
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
        {
            //minimap.orthographicSize--;
            t.text = Input.GetAxis("Mouse ScrollWheel").ToString();
        }
        distValue += Input.GetAxis("Mouse ScrollWheel");

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
            this.transform.localPosition = new Vector3(0, 0, distValue);
        }

        this.transform.rotation = this.transform.parent.rotation;
    }
}
