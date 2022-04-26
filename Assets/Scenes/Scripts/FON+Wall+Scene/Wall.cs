using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public ClickMove STOP;
    public Palatform Platform;
    // Start is called before the first frame update
    private bool Exit;
    
    public void OnCollisionStay2D(Collision2D collision)
    {
        //if (Exit == true)
        //{
              STOP.stop = true;
        //    Exit = false;
        //}
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        //Debug.Log("ушёл ");
        //if (Platform.ClickZone == true)
        //{
        //    STOP.stop = false;
        //}
        //Exit = true;
    }
}
