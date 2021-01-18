using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheamaPacient : MonoBehaviour
{
    public GameObject caracter;

    // Start is called before the first frame update
    void Start()
    {

        caracter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("b"))
        {
            caracter.SetActive(true);
        }
    }
}
