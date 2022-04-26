using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProverkaInv : MonoBehaviour
{
    // Start is called before the first frame update
    public Inventory inventory;
    GameObject object1;
    public void Start()
    {
        //inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //object1 = GameObject.FindGameObjectsWithTag("Boris_0");
        //TochkaRazg sp1 = object1.GetComponent<TochkaRazg>();
        //sp1.enabled = true;
        //for (int i = 0; i < inventory.Slots.Length; i++)
        //{
        //    if (inventory.slotIsFull[i] == false)
        //    {
        //        inventory.slotIsFull[i] = true;
        //        Instantiate(slotButton, inventory.Slots[i].transform);
        //        Destroy(gameObject);
        //        break;
        //    }
        //}
    }
}
