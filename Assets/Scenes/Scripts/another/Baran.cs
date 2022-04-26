using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baran : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject a;
    public ToporTrue Topor;
    public Inventory inventory;
    public TochkaRazg iper;
    private int k = 0;
    public GameObject slotButton;
    public bool vodka = false; 
    public void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Topor.ToporTruee && k ==0)
        {
            a = GameObject.FindGameObjectWithTag("Topor");
            Destroy(a);
            k++;
            
        }
        
        //if(k==1) 
        //{

        //}
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (k == 1)
        {
            for (int i = 0; i < inventory.Slots.Length; i++)
            {
                if (inventory.slotIsFull[i] == false)
                {
                    inventory.slotIsFull[i] = true;
                    Instantiate(slotButton, inventory.Slots[i].transform);
                    break;
                }
            }
            vodka = true;
        }
        
    }
}
