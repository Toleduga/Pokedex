using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_Gate : MonoBehaviour
{

    AudioSource sound;
    AudioSource soundclose;
    public Animator animator;
    

   
    public bool abierto = false;
    // Start is called before the first frame update
    void Start()
    {
        sound = GameObject.Find("Button").GetComponent<AudioSource>();
        soundclose = GameObject.Find("Button_Exit").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown("space") && (abierto == false))
        {
            animator.SetTrigger("Open");
            sound.Play();
            abierto = true;
        }
        if (Input.GetKeyDown("return") && (abierto == false))
        {
            animator.SetTrigger("Open");
            sound.Play();
            abierto = true;
        }

        if (Input.GetKeyDown("escape") && (abierto))
        {
            animator.SetTrigger("Close");
            soundclose.Play();
            abierto = false;
            

        }
    }

    public void ButtonOpen()
    {
        abierto = true;
        animator.SetTrigger("Open");
        sound.Play();
    }
    public void ButtonClose()
    {
        animator.SetTrigger("Close");
        abierto = false;
        soundclose.Play();
    }
}
