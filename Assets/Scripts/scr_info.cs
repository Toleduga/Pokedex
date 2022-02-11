using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_info : MonoBehaviour
{

    public int n_Pokemon;
    public SCR_NumPokemon refpokemon;

    string Text_ps;
    string Text_ataque;
    string Text_defensa;
    string Text_aespecial;
    string Text_despecial;
    string Text_velocidad;

    public Text text_PS;
    public Text text_Ataque;
    public Text text_Defensa;
    public Text text_A_Especial;
    public Text text_D_Especial;
    public Text text_Velocidad;

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
            Text_ps = "45"; 
            Text_ataque = "49";
            Text_defensa = "49";
            Text_aespecial = "65";
            Text_despecial = "65";
            Text_velocidad = "45";
        }
        if (n_Pokemon == 2)
        {
            Text_ps = "39";
            Text_ataque = "52";
            Text_defensa = "43";
            Text_aespecial = "60";
            Text_despecial = "50";
            Text_velocidad = "65";
        }
        if (n_Pokemon == 3)
        {
            Text_ps = "44";
            Text_ataque = "48";
            Text_defensa = "65";
            Text_aespecial = "50";
            Text_despecial = "64";
            Text_velocidad = "43";
        }

        text_PS.text = Text_ps;
        text_Ataque.text = Text_ataque;
        text_Defensa.text = Text_defensa;
        text_A_Especial.text = Text_aespecial;
        text_D_Especial.text = Text_despecial;
        text_Velocidad.text = Text_velocidad;
    }
}
