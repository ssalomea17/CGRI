using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instructiuni : MonoBehaviour
{
    public Text te;


    enum state
    {
        mg_Lab,
        cheama_pac,
        ia_sir,
        sch_cam,
        ridica_mana,
        recoltea,
        ia_eprubeta,
        puneInEprub,
        Sfarsit,
    }

    state plState;


    public Renderer sir;
    public Renderer eprubeta;

    // Start is called before the first frame update
    void Start()
    {
        plState = state.mg_Lab;
    }

    bool have_pac = false;
    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, GameObject.Find("Sample Collection_MD_04_AAA").transform.position) < 2 && !have_pac)
        {            
            plState = state.cheama_pac;
            have_pac = true;
        }
        if (Input.GetKey("b"))
        {
            plState = state.ia_sir;
        }
        if (Input.GetKey("g"))
        {
            plState = state.sch_cam;
        }

        if (Input.GetKey("f"))
        {
            plState = state.ridica_mana;
        }
        if (Input.GetKey("r"))
        {
            plState = state.ia_eprubeta;
        }

        if (Input.GetKey("p"))
        {
            plState = state.puneInEprub;
        }
        if (Input.GetKey("c"))
        {
            plState = state.Sfarsit;
        }


        switch (plState)
        {
            case state.mg_Lab:
                te.text = "Mergeti in cabinetul FUCHSIA\n";
                te.text += "Mai aveti: " + (Vector3.Distance(transform.position, GameObject.Find("Sample Collection_MD_04_AAA").transform.position)).ToString();
                break;
            case state.cheama_pac:
                te.text = "Chemati un pacient apasand tasta b";
                break;
            case state.ia_sir:
                te.text = "Pentru a putea lua siringa apasati g\n";
                te.text += "Ducetiva la pacient";
                break;
            case state.sch_cam:
                te.text = "Pentru a schimba camera cu cea frontala apsati f\n";
                break;
            case state.ridica_mana:
                te.text = "Pentru a-i spune pacientului sa ridice/coboare mana apasati r";
                te.text += "Pentru a recolta trebuie sa atingeti cu siringa bratul pacientului";
                break;
            case state.ia_eprubeta:
                te.text = "Pentru a putea lua eprubeta apasati p\n";
                break;
            case state.puneInEprub:
                te.text = "Pentru a muta sangele din siringa in eprubeta apasati c\n";
                break;
            case state.Sfarsit:
                te.text = "Ai recoltat cu succes";
                break;
        }
    }
}
