using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Animations.Rigging;

public class GetEprubet : MonoBehaviour
{
    public Rig rig;
    public String Leter;
    private float time = 0;
    public GameObject eprubeta;

    bool ridica = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(Leter))
        {
            if (Time.time > time + 0.5)
            {
                time = Time.time;
                ridica = !ridica;
            }
        }

        if (ridica)
        {
            eprubeta.gameObject.SetActive(true);
            if (rig.weight < 0.99f)
                rig.weight += 0.01f;
        }
        else
        {
            eprubeta.gameObject.SetActive(false);
            if (rig.weight > 0.01f)
                rig.weight -= 0.01f;
        }
    }
}
