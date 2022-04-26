using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTochka : MonoBehaviour
{
    public string text;
    public TochkaRazg iper;
    public ToporTrue Topor;
    public string[] dialogue2 = new string[10];
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(Topor.ToporTruee)
        if (iper.dialogue[iper.i] == "")
        {
            for (int i = 0; i < dialogue2.Length; i++)
                iper.dialogue[i] = dialogue2[i];
            iper.i = 0;
        }
    }
    
}
