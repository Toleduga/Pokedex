using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class SC_List : MonoBehaviour
{
    public string num;
    public Text textnum;
    public string pname;
    public Text textName;
    

    public Image Pimage; 
 
    void Start()
    {
        textnum.text = '#' + num;
        textName.text = pname;
        Pimage.sprite = Resources.Load<Sprite>("Sprites/" + num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


   
    
