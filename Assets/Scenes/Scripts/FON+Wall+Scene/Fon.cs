using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fon : MonoBehaviour
{
    public ClickMove STOP;
    //public Platform ClickZ;
    private void OnMouseDown()
    {
        STOP.stop = true;
        Debug.Log("Есть пробитие");
    }
   
}
