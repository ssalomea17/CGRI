using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalDetailes : MonoBehaviour
{
    List<string> names = new List<string>
    {
"Noah       ",
"Oliver     ",
"William    ",
"Elijah     ",
"James      ",
"Benjamin   ",
"Lucas      ",
"Mason      ",
"Ethan      ",
"Alexander  ",
"Henry      ",
"Jacob      ",
"Michael    ",
"Daniel     ",
"Logan      ",
"Jackson    ",
"Sebastian  ",
"Jack       ",
"Aiden      ",
"Owen       ",
"Samuel     ",
"Matthew    ",
"Joseph     ",
"Levi       ",
"Mateo      ",
"David      ",
"John       ",
"Wyatt      ",
"Carter     ",
"Julian     ",
"Luke       ",
"Grayson    ",
"Isaac      ",
"Jayden     ",
"Theodore   ",
"Gabriel    ",
"Anthony    ",
"Dylan      ",
"Leo        ",
"Lincoln    ",
"Jaxon      ",
"Asher      ",
"Christopher",
"Josiah     ",
"Andrew     ",
"Thomas     ",
"Joshua     ",
"Ezra       ",
"Hudson     ",
"Charles    ",
"Caleb      ",
"Isaiah     ",
"Ryan       ",
"Nathan     ",
"Adrian     ",
"Christian  ",
"Maverick   "
    };

    
    static System.Random rnd = new System.Random();
    public TextMesh t;
    // Start is called before the first frame update
    void Start()
    {

        t.text = names[rnd.Next(names.Count)];


    }

    // Update is called once per frame
    void Update()
    {
    }
}
