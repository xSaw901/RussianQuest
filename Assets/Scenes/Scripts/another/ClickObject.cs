using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickObject : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Click = false;
    public Text T;
    public string text;
    public TochkaRazg iper;
    public string[] dialogue2 = new string[10];
    private int j = 0;
    
    private void OnMouseDown()
    {
        Click = true;
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Click && iper.dialogue[iper.i]=="" && j==0)
        {
            j++;
            for (int i = 0; i < dialogue2.Length; i++)
                iper.dialogue[i] = dialogue2[i];
            T.text = text;
            iper.i = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        T.text = "";
    }

}
