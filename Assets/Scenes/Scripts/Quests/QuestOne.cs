using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestOne : MonoBehaviour
{
    public string[] dialogue = new string[7];
    public Text T;
    public int i=0;
    public ClickMove STOP;
    public GameObject Platf;
    private int h = 0;

    public void Update()
    {
        //STOP.stop = t;

        if (STOP.stop && Input.GetKeyDown(KeyCode.E) && i<7)
        {

            T.text = dialogue[i];
            i++;
        }
        if (STOP.stop && i == 7 && Input.GetKeyDown(KeyCode.E))
            StartCoroutine(wait());
        if (i > 7 && h==0)
        {
            T.text = "";
            STOP.stop = false;
            h++;
        }

    }
    public void OnTriggerStay2D(Collider2D collision)
    {
            if (Input.GetKeyDown(KeyCode.E))
            {

            STOP.stop = true;
            Platf.SetActive(false); 
            }
            if (i >7)
            {
            STOP.stop = false;
            Platf.SetActive(true);
            }
        
    }

    public IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);
        i++;
    }
    //private void OnTriggerStay()
    //{

    //        if (Input.GetKeyDown(KeyCode.E))
    //        {
    //            T.text = dialogue[i];
    //            STOP.stop = true;    
    //                i++;
    //        }
    //        if(i==dialogue.Length)
    //           STOP.stop = false;

    //}
}
