using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTochkaVodka : MonoBehaviour
{
    // Start is called before the first frame update
    public string text;
    public TochkaRazg iper;
    public Baran Vodka;
    public string[] dialogue2 = new string[10];
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Vodka.vodka)
            if (iper.dialogue[iper.i] == "")
            {
                for (int i = 0; i < dialogue2.Length; i++)
                    iper.dialogue[i] = dialogue2[i];
                iper.i = 0;
            }
    }
}
