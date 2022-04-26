using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWall : MonoBehaviour
{
    public ClickMove STOP;
    private void OnMouseDown()
    {
        STOP.stop = true;
        
    }
}
