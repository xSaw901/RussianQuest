using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChelTarget : MonoBehaviour
{
    public GameObject player;
    public GameObject tchel;
    public int i = 0;
    public DiaList word;
    public ClickMove move;
    public Text txt;
    public bool pt = false;
    public bool ticket=false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        pt = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        pt = false;
    }
    private void Update()
    {
        if (pt)
            if (Input.GetKeyDown(KeyCode.E) && i < word.chel.Length)
            {
                move.stop = true;
                txt.text = word.chel[i];
                i++;
            }
        if (i >= word.chel.Length)
        {
            pt = false;
            ticket = true;
        }
    }
}
