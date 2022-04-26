using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palatform : MonoBehaviour
{
    public ClickMove STOP;
    public bool ClickZone;
    //public Pickup YES;
    //public Pickup YES2;
    public Pickup []YES = new Pickup[10];
    GameObject a;
    public void Awake()
    { 
        a = GameObject.FindWithTag("Player");
        STOP = a.GetComponent<ClickMove>();
    }
    private void OnMouseDown()
    {
        STOP.stop = false;
        for(int i =0; i<YES.Length; i++)
        {   
            if(YES[i]!=false)
            YES[i].Yes = false;
        }
    }
}
