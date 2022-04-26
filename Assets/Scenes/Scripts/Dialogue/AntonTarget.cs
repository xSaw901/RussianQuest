using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AntonTarget : MonoBehaviour
{
    public GameObject player;
    public GameObject tanton;
    public int i = 0;
    public DiaList word;
    public ClickMove move;
    public Text txt;
    public bool ptt = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ptt = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        ptt = false;
    }
    private void Update()
    {
        if (ptt)
            if (Input.GetKeyDown(KeyCode.E) && i < word.anton.Length)
            {
                move.stop = true;
                txt.text = word.anton[i];
                i++;
            }
        if (i >= word.anton.Length)
            ptt = false;
    }
}
