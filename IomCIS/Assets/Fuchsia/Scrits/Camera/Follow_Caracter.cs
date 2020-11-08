using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Caracter : MonoBehaviour
{
    public GameObject caracter;

    private Vector3 dist;
    private Vector3 dist1;

    // Start is called before the first frame update
    void Start()
    {
        dist = caracter.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float desiredAngle = caracter.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = caracter.transform.position - (rotation * dist);        
        transform.LookAt(caracter.transform);
    }
}
