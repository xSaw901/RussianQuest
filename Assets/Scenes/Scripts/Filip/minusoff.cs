using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minusoff : MonoBehaviour
{
    public MinusFill Puzo;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Puzo.Puzo)
        {
            GameObject object1 = GameObject.Find("TochkaFillip");
            TochGameObj sp1 = object1.GetComponent<TochGameObj>();
            sp1.enabled = true;
        }
        else
        {
            GameObject object1 = GameObject.Find("TochkaFillip");
            TochGameObj sp1 = object1.GetComponent<TochGameObj>();
            sp1.enabled = false;
        }
    }
}
