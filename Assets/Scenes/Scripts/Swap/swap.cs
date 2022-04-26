using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swap : MonoBehaviour
{
    public GameObject Object;
    public GameObject Object2;
    public Vector3 newpos;
    public Vector3 oldpos;
    public Vector3 pos;
    private bool gnom = true;
    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gnom)
            {
                pos = newpos;
                gnom = !gnom;
            }
            else
            {
                pos = oldpos;
                gnom = !gnom;
            }
            Object.transform.position = pos;
        }


    }
}
