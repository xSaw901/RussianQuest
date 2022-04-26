using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapLocation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject cam;
    public Vector3 Vcam;
    public Vector3 Vplayer;
    public ClickMove STOP;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public void Click()
    {
        
        cam.transform.position = Vcam;
        player.transform.position = Vplayer;
        STOP.stop = true;
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
        

        if (cam.transform.position == new Vector3(0, 0, -10))
        {
            b1.SetActive(true);
            b2.SetActive(false);
            b3.SetActive(false);
        }
        else if (cam.transform.position == new Vector3(-20, 0, -10))
        {
            b1.SetActive(false);
            b2.SetActive(true);
            b3.SetActive(false);
        }
        else {
            b1.SetActive(false);
            b2.SetActive(false);
            b3.SetActive(true);
        }
    }
}
