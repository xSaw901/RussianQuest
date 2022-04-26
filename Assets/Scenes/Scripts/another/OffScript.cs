using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffScript : MonoBehaviour
{

    
    //bool y = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (this.gameObject.name == "TochkaFillip")
        //{
        //    GameObject object1 = GameObject.Find("Boris_0");
        //    TochkaRazg sp1 = object1.GetComponent<TochkaRazg>();
        //    sp1.enabled = false;

        //    object1 = GameObject.Find("Makar_0");
        //    TochkaRazg sp2 = object1.GetComponent<TochkaRazg>();
        //    sp2.enabled = false;

        //    object1 = GameObject.Find("Radik_0");
        //    TochkaRazg sp3 = object1.GetComponent<TochkaRazg>();
        //    sp3.enabled = false;

        //}
        if (this.gameObject.name == "TochkaBoris")
        {
            //GameObject object1 = GameObject.Find("Filip_0");
            //TochkaRazg sp1 = object1.GetComponent<TochkaRazg>();
            //sp1.enabled = false;

            GameObject object1 = GameObject.Find("Makar_0");
            TochkaRazg sp2 = object1.GetComponent<TochkaRazg>();
            sp2.enabled = false;

            object1 = GameObject.Find("Radik_0");
            TochkaRazg sp3 = object1.GetComponent<TochkaRazg>();
            sp3.enabled = false;
        }
        if (this.gameObject.name == "TochkaMakar")
        {
            GameObject object1 = GameObject.Find("Boris_0");
            TochkaRazg sp1 = object1.GetComponent<TochkaRazg>();
            sp1.enabled = false;

            //object1 = GameObject.Find("Filip_0");
            //TochkaRazg sp2 = object1.GetComponent<TochkaRazg>();
            //sp2.enabled = false;

            object1 = GameObject.Find("Radik_0");
            TochkaRazg sp3 = object1.GetComponent<TochkaRazg>();
            sp3.enabled = false;
        }
        if (this.gameObject.name == "TochkaRadik")
        {
            GameObject object1 = GameObject.Find("Boris_0");
            TochkaRazg sp1 = object1.GetComponent<TochkaRazg>();
            sp1.enabled = false;

            //object1 = GameObject.Find("Filip_0");
            //TochkaRazg sp2 = object1.GetComponent<TochkaRazg>();
            //sp2.enabled = false;

            object1 = GameObject.Find("Makar_0");
            TochkaRazg sp3 = object1.GetComponent<TochkaRazg>();
            sp3.enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //if (this.gameObject.name == "TochkaFillip")
        //{
        //    GameObject object1 = GameObject.Find("Boris_0");
        //    TochkaRazg sp1 = object1.GetComponent<TochkaRazg>();
        //    sp1.enabled = true;

        //    object1 = GameObject.Find("Makar_0");
        //    TochkaRazg sp2 = object1.GetComponent<TochkaRazg>();
        //    sp2.enabled = true;

        //    object1 = GameObject.Find("Radik_0");
        //    TochkaRazg sp3 = object1.GetComponent<TochkaRazg>();
        //    sp3.enabled = true;

        //}
        if (this.gameObject.name == "TochkaBoris")
        {
            //GameObject object1 = GameObject.Find("Filip_0");
            //TochkaRazg sp1 = object1.GetComponent<TochkaRazg>();
            //sp1.enabled = true;

            GameObject object1 = GameObject.Find("Makar_0");
            TochkaRazg sp2 = object1.GetComponent<TochkaRazg>();
            sp2.enabled = true;

            object1 = GameObject.Find("Radik_0");
            TochkaRazg sp3 = object1.GetComponent<TochkaRazg>();
            sp3.enabled = true;
        }
        if (this.gameObject.name == "TochkaMakar")
        {
            GameObject object1 = GameObject.Find("Boris_0");
            TochkaRazg sp1 = object1.GetComponent<TochkaRazg>();
            sp1.enabled = true;

            //object1 = GameObject.Find("Filip_0");
            //TochkaRazg sp2 = object1.GetComponent<TochkaRazg>();
            //sp2.enabled = true;

            object1 = GameObject.Find("Radik_0");
            TochkaRazg sp3 = object1.GetComponent<TochkaRazg>();
            sp3.enabled = true;
        }
        if (this.gameObject.name == "TochkaRadik")
        {
            GameObject object1 = GameObject.Find("Boris_0");
            TochkaRazg sp1 = object1.GetComponent<TochkaRazg>();
            sp1.enabled = true;

            //object1 = GameObject.Find("Filip_0");
            //TochkaRazg sp2 = object1.GetComponent<TochkaRazg>();
            //sp2.enabled = true;

            object1 = GameObject.Find("Makar_0");
            TochkaRazg sp3 = object1.GetComponent<TochkaRazg>();
            sp3.enabled = true;
        }
    }
}
