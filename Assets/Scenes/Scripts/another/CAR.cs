using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAR : MonoBehaviour
{
    GameObject a;
    public Inventory inventory;
    
    private int j = 0;
    public bool complited = false;
    bool click = false;
    public void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    private void OnMouseDown()
    {
        click = true;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (click)
        {
            Debug.Log("tcc");
            if (j == 0)
            {
                a = GameObject.FindGameObjectWithTag("Shlang");
                Destroy(a);
                j++;
                complited = true; 
            }
        }
        else
        {
            click = false;
            j = 0;
        }
    }
}
