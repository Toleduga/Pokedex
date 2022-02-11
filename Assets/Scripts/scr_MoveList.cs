using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scr_MoveList : MonoBehaviour
{
    int select = 1;
    int oldSelect = 1;
    public int N_Pokemones = 5;

    Image imageSelect;
    Color fondo = Color.white;
    Color sinfondo = Color.white;
    public Scrollbar scroll_list;

    void Start()
    {
        imageSelect = GameObject.Find("Pokemon#2").GetComponent<Image>();
        sinfondo[3] = imageSelect.color[3];
        fondo[3] = 255;
        scroll_list = GameObject.Find("Scroll").GetComponent <Scrollbar>();
    }

    // Update is called once per frame
    void Update()
    {
        oldSelect = select;

        if (Input.GetKeyDown("up"))
        {
            select = select - 1;
            if (select < 1)
            { select = 1; }
        }
        if (Input.GetKeyDown("down"))
        {
            select = select + 1;
            if (select > N_Pokemones)
            { select = N_Pokemones; }
        }
        if (select > 3)
        { 
           scroll_list.value = 5f;
        }


        if (select != oldSelect)
        {
            imageSelect = GameObject.Find("Pokemon#" + oldSelect).GetComponent<Image>();
            imageSelect.color = sinfondo;
            imageSelect = GameObject.Find("Pokemon#" + select).GetComponent<Image>();
            imageSelect.color = fondo;
        }
        else
        { 
            imageSelect = GameObject.Find("Pokemon#" + select).GetComponent<Image>();
                imageSelect.color = fondo;
            
        }
       
        
    }
}
