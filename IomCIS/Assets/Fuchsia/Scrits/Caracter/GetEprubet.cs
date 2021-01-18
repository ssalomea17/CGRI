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

    Vector3 initial_poz;
    Quaternion initial_rot;
    Transform initia_parent;


    // Start is called before the first frame update
    void Start()
    {
        initial_poz = GameObject.Find("Sample Collection_MD_04_AAA").transform.position;
        initial_rot = GameObject.Find("Sample Collection_MD_04_AAA").transform.rotation;
        initia_parent = GameObject.Find("Sample Collection_MD_04_AAA").transform.parent;
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

            GameObject.Find("Sample Collection_MD_04_AAA").transform.parent = GameObject.Find("mixamorig:LeftHandThumb2").transform;

            GameObject.Find("Sample Collection_MD_04_AAA").transform.localPosition = new Vector3(-0.02f, 0, -0.02f);
            GameObject.Find("Sample Collection_MD_04_AAA").transform.localRotation = new Quaternion(0, 1, 0, 0);
            //eprubeta.gameObject.SetActive(true);
            /*if (rig.weight < 0.99f)
                rig.weight += 0.01f;*/
        }
        else
        {
            GameObject.Find("Sample Collection_MD_04_AAA").transform.parent = initia_parent;
            GameObject.Find("Sample Collection_MD_04_AAA").transform.rotation = initial_rot;
            GameObject.Find("Sample Collection_MD_04_AAA").transform.position = initial_poz;
            //eprubeta.gameObject.SetActive(false);
            /*if (rig.weight > 0.01f)
                rig.weight -= 0.01f;*/
        }
    }
}
