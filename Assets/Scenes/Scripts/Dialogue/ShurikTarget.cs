using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShurikTarget : MonoBehaviour
{
    public GameObject player;
    public GameObject tshurik;
    public int i = 0;
    public DiaList word;
    public ClickMove move;
    public Text txt;
    public bool p = false;

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        p=true; 
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        p = false;
    }
    private void Update()
    {
        if (p)
        if (Input.GetKeyDown(KeyCode.E) && i < word.shurik.Length)
        {
            move.stop = true;
            txt.text = word.shurik[i];
            i++;
        }
        if(i>=word.shurik.Length)
                p= false;
    }

}
