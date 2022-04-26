using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    bool a= false;
    public ClickMove move;

    public GameObject tshurik;
    public GameObject tanton;
    public GameObject tchel;
    public GameObject cam;


    private void OnMouseDown()
    {
        a = true;
    }
    private void Update()
    {
        if(a)
        if(cam.transform.position== new Vector3(0,0,-10))
        if (move.isMoving)
        { 
        move.TargetPosition =tshurik.transform.position;
                    a=false;
        }

        if(a)
        if (cam.transform.position == new Vector3(-20, 0, -10))
        {
            if (move.isMoving)
            {
                move.TargetPosition = tanton.transform.position;
                a = false;
            }
        }
        if (a)
            if (cam.transform.position == new Vector3(-20, 13, -10))
            {
                if (move.isMoving)
                {
                    move.TargetPosition = tchel.transform.position;
                    a = false;
                }
            }


    }
    
}
