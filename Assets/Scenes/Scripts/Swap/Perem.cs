using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perem : MonoBehaviour
{
    public GameObject Object2;
    public Vector3 newpos;
    public Vector3 oldpos;
    public Vector3 pos;
    private bool gnom = true;
    public ClickMove STOP;
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
            STOP.stop = true;
            StartCoroutine(wait());
            Object2.transform.position = pos;
        }
        // не останавливается 
    }

    public IEnumerator wait()
    {
        yield return new WaitForSeconds(0.1f);
        STOP.stop = false;
    }
}
