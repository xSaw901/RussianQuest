using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    public Inventory inventory;
    public GameObject slotButton;
    public ClickMove STOP,Xvat;
    public GameObject Platf;
    //public Animator anim;
    public bool Yes = false;

    public void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            if (Yes)
            {
                STOP.stop = true;
                Platf.SetActive(false);
                Xvat.Xvat = true;
                StartCoroutine(wait());
            }
        }
    }
    public void OnMouseDown()
    {
        Yes = true;
    }
    public IEnumerator wait()
    { 
        yield return new WaitForSeconds(1f);
        Xvat.Xvat = false; 
        Platf.SetActive(true);
        STOP.stop = false;
            for (int i = 0; i < inventory.Slots.Length; i++)
            {
                if (inventory.slotIsFull[i] == false)
                {
                    inventory.slotIsFull[i] = true;
                    Instantiate(slotButton, inventory.Slots[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
            Yes = false;
    }
}
