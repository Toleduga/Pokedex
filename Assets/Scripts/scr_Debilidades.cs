using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_Debilidades : MonoBehaviour
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
    Color color_Electrico = new Color(0.97f, 0.81f, 0.18f, 1.0f);
    Color color_Roca = new Color(0.75f, 0.62f, 0.22f, 1.0f);
    Color color_Psiquico = new Color(0.97f, 0.35f, 0.53f, 1.0f);
    Color color_Transparente = new Color(0.94f, 0.5f, 0.19f, 0f);

    public SCR_NumPokemon refpokemon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        n_Pokemon = refpokemon.select;

        if (n_Pokemon == 1)
        {
            Text_Tipo1 = "Fuego";
            Tipo1.color = color_Fuego;
            Text_Tipo2 = "Psíquico";
            Tipo2.color = color_Psiquico;
        }

        if (n_Pokemon == 2)
        {
            Text_Tipo1 = "Agua";
            Tipo1.color = color_Agua;
            Text_Tipo2 = "Roca";
            Tipo2.color = color_Roca;
        }
        if (n_Pokemon == 3)
        {
            Text_Tipo1 = "Planta";
            Tipo1.color = color_Planta;
            Text_Tipo2 = "Eléctrico";
            Tipo2.color = color_Electrico;
        }

        text_Tipo1.text = Text_Tipo1;
        text_Tipo2.text = Text_Tipo2;
    }
}
