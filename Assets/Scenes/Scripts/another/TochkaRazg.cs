using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TochkaRazg : MonoBehaviour
{
    public GameObject Tochka;
    public ClickMove TP,STOP;
    public GameObject Platf;
    public Text T;
    public string[] dialogue = new string[10];
    public int i = 0;
    public int h = 0;
    private bool Hohoho = false;
    
    private void OnMouseDown()
    { 
        if(TP.transform.position != Tochka.transform.position)
        {
            Hohoho = true;
            Tochka.SetActive(true);
        }                
    }
    private void Update()
    {
        if (Hohoho)
        {
            if (TP.isMoving)
            {
                TP.TargetPosition = Tochka.transform.position;
                TP.TargetPosition.z = TP.transform.position.z;
            }  
        }
        if (TP.transform.position == Tochka.transform.position && Hohoho == true)
        {
            Hohoho = false;
            h = 0;
        }






        if (dialogue[i] != "")
        {
            if (STOP.stop && Input.GetKeyDown(KeyCode.E) && i < dialogue.Length)
            {
                T.text = dialogue[i];
                i++;
            }
            if (STOP.stop && i == dialogue.Length && Input.GetKeyDown(KeyCode.E))
                StartCoroutine(wait());
            if (i > dialogue.Length && h == 0)
            {
                T.text = "";
                STOP.stop = false;
                Tochka.SetActive(false);
                h++;
            }
        }
        if (dialogue[i] == "" && h==0 && Input.GetKeyDown(KeyCode.E))
        StartCoroutine(wait2());
        if (dialogue[i] == "" && h==1)
        {
            
            T.text = "";
            STOP.stop = false;
            Tochka.SetActive(false);
            Platf.SetActive(true);
            h = 0;
        }
    }

    public IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);

        i++;
    }
    public IEnumerator wait2()
    {
        yield return new WaitForSeconds(2f);
        h++;
    }
} 
