using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moveVector = (transform.forward * v) + (transform.right * h);

        moveVector *= speed * Time.deltaTime;

        transform.localPosition += moveVector;

        if (Input.GetKey("q"))
        {
            transform.Rotate(0, -0.5f, 0);
        }
        else if (Input.GetKey("e"))
        {
            transform.Rotate(0, 0.5f, 0);
        }

    }
}
