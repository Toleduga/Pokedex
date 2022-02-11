using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_Tipo_Pokemon : MonoBehaviour
{
    public int n_Pokemon;
   
    string Text_Tipo1;
    string Text_Tipo2;

    public Text text_Tipo1;
    public Text text_Tipo2;

    public Image Tipo1;
    public Image Tipo2;

    Color color_Planta = new Color(0.47f, 0.78f, 0.3f, 1.0f);
    Color color_Veneno = new Color(0.63f, 0.25f, 0.63f, 1.0f);
    Color color_Fuego = new Color(0.94f, 0.5f, 0.19f, 1.0f);
    Color color_Agua = new Color(0.4f, 0.56f, 0.94f, 1.0f);
    Color color_Transparente = new Color(0.94f, 0.5f, 0.19f, 0f);

    public SCR_NumPokemon refpokemon;

    void Start()
    {
       // refpokemon = GameObject.Find("Pokedex").GetComponent<SCR_NumPokemon>();
    }

    // Update is called once per frame
    void Update()
    {
        n_Pokemon = refpokemon.select;

        if (n_Pokemon == 1)
        {
            Text_Tipo1 = "Planta";
            Tipo1.color = color_Planta;
            Text_Tipo2 = "Veneno";
            Tipo2.color = color_Veneno;
        }

        if (n_Pokemon == 2)
        {
            Text_Tipo1 = "Fuego";
            Tipo1.color = color_Fuego;
            Text_Tipo2 = "";
            Tipo2.color = color_Transparente;
        }
        if (n_Pokemon == 3)
        {
            Text_Tipo1 = "Agua";
            Tipo1.color = color_Agua;
            Text_Tipo2 = "";
            Tipo2.color = color_Transparente;
        }

        text_Tipo1.text = Text_Tipo1;
        text_Tipo2.text = Text_Tipo2;
    }
}
