using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vodkadel : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject a;
    public Baran vod;
    public Inventory inventory;
    public TochkaRazg iper;
    private int j = 0;
    public GameObject slotButton;
    public bool vodka = false;
    public bool Swap = false;
    public void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (vod.vodka && j == 0)
        {
            a = GameObject.FindGameObjectWithTag("vodka");
            Destroy(a);
            j++;
            vodka = false;
            Swap = true;
        }

        //if(k==1) 
        //{

        //}
    }
}
