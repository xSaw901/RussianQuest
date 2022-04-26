using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF : MonoBehaviour
{
    public TochkaRazg iper;
    public vodkadel swap;
    public GameObject SwapDoor;
    public GameObject SwapGar;
    //public GameObject SwapGar;
    void Update()
    {
        if (iper.i == 7)
        {
           SwapDoor.SetActive(true);
        }
        if(swap.Swap)
        {
           SwapGar.SetActive(true);
        }    
    }
}
