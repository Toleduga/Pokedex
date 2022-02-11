using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_NumPokemon : MonoBehaviour
{
    AudioSource sound;
    public int select = 1;
    public Text n_Pokemon;
    public Text name_Pokemon;
    public Image image_pokemon;
    public Animator anim_Der;
    public Animator anim_Izq;

    // Start is called before the first frame update
    void Start()
    {
        sound = GameObject.Find("B_Izq").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            anim_Izq.SetTrigger("Click");
            select = select - 1;
            if (!sound.isPlaying)
            { sound.Play(); }
            if (select < 1)
            { select = 3; }
        }
        if (Input.GetKeyDown("right"))
        {
            anim_Der.SetTrigger("Clickder");
            select = select + 1;
            if (!sound.isPlaying)
            { sound.Play(); }
            if (select > 3)
            { select = 1; }
        }

        n_Pokemon.text = "#00" + select;

        if (select == 1)
        {
            name_Pokemon.text = "Boulbasor";
            image_pokemon.sprite = Resources.Load<Sprite>("Sprites/00" + select);
        }
        if (select == 2)
        {
            name_Pokemon.text = "Charmander";
            image_pokemon.sprite = Resources.Load<Sprite>("Sprites/00" + select);
        }
        if (select == 3)
        {
            name_Pokemon.text = "Squirtle";
            image_pokemon.sprite = Resources.Load<Sprite>("Sprites/00" + select);
        }

    }


    public void ButtonDer()
    {
        select = select + 1;
        if (select > 3)
        { select = 1; }
    }
    public void ButtonIzq()
    {
        select = select - 1;
        if (select < 1)
        { select = 3; }
    }
}
