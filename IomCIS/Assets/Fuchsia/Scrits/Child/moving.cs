using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    Animation animatie;

    public GameObject caracter;

    float viteza = 2.0f;


    Vector3 initial;
    bool walk = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        animatie = caracter.GetComponent<Animation>();
        initial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            walk = true;
            gameObject.GetComponent<Renderer>().enabled = true;
        }
        if (walk)
        {
            if (Vector3.Distance(caracter.transform.position, initial) < 3)
            {
                transform.Translate(0, 0, Time.deltaTime * viteza);
                animatie.Play("Walking");
            }
            else
            {
                animatie.Stop("Walking");
            }
        }

        //print(Vector3.Distance(caracter.transform.position, initial));
    }
}
