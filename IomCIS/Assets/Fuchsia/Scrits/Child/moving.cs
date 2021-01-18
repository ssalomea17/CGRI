using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    float time;
    Animation animatie;

    public GameObject caracter;

    float viteza = 2.0f;


    Vector3 initial;


    public Transform leftUpLeg;
    public Transform rightUpLeg;

    public Transform theDest;

    bool staPeScaun = false;

    enum state
    {
        start,
        go0,
        rot1,
        go,
        wait,
        turnaround,
        go1,
        sit,
        finish,
    }

    state plState;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<Renderer>().enabled = false;
        animatie = caracter.GetComponent<Animation>();
        initial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        switch (plState)
        {
            case state.start:
                plState = state.go0;
                break;
            case state.go0:

                //this.enabled = true;
                if (Vector3.Distance(caracter.transform.position, initial) < 3)
                {
                    transform.Translate(0, 0, Time.deltaTime * viteza);
                    animatie.Play("Walking");
                }
                else
                {
                    animatie.Stop("Walking");
                    plState = state.rot1;
                    initial = transform.position;
                }
                break;
            case state.rot1:
                print("ma rotesc");
                transform.Rotate(transform.rotation.x, 40, transform.rotation.z, Space.Self);

                plState = state.go;
                break;
            case state.go:
                if (Vector3.Distance(caracter.transform.position, initial) < 1)
                {
                    transform.Translate(0, 0, Time.deltaTime * viteza);
                    animatie.Play("Walking");
                }
                else
                {
                    animatie.Stop("Walking");
                    plState = state.wait;
                    initial = transform.position;
                    time = Time.time;
                }
                break;
            case state.wait:
                if (Time.time > time + 2)
                {
                    plState = state.turnaround;
                }
                break;
            case state.turnaround:
                transform.Rotate(transform.rotation.x, 110, transform.rotation.z, Space.Self);

                plState = state.go1;
                break;
            case state.go1:
                if (Vector3.Distance(caracter.transform.position, initial) < 1)
                {
                    transform.Translate(0, 0, Time.deltaTime * viteza);
                    animatie.Play("Walking");
                }
                else
                {
                    animatie.Stop("Walking");
                    plState = state.sit;
                    initial = transform.position;
                }

                break;
            case state.sit:
                this.transform.parent = theDest;
                this.transform.localPosition = new Vector3(0, 0.1000004f, 0);
                this.transform.rotation = new Quaternion(0, 0, 0, 0);

                if (!staPeScaun)
                {
                    // Dampen towards the target rotation
                    leftUpLeg.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
                    rightUpLeg.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
                    //plState = state.finish;
                    staPeScaun = !staPeScaun;
                }

                break;
            default:
                break;

        }



        //print(Vector3.Distance(caracter.transform.position, initial));
    }
}
