using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class size : MonoBehaviour
{
    RectTransform rT;
    // Start is called before the first frame update
    void Start()
    {
        rT = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = new Vector3(1, 1, 1);
    }
}
