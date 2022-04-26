using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TochGameObj : MonoBehaviour
{
    public TochkaRazg iper;
    public ClickMove STOP;
    public GameObject Platf;
    //public GameObject gogo; 
    private void Update()
    {
        
            

        
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        //this.GetComponent<SpriteRenderer>().color = new Color(255,0,0);
        if (STOP.transform.position == transform.position)
        //if (Input.GetKeyDown(KeyCode.E))
        {
                STOP.stop = true;
                Platf.SetActive(false);
        } 
        else
        {
            STOP.stop = false;
        }

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        //this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
    }
}
