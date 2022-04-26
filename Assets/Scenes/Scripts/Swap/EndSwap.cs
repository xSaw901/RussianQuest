using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSwap : MonoBehaviour
{
    bool a = false;
    public GameObject player;
    public GameObject cubewait;
    public GameObject cam;
    public ChelTarget tic;
    public ClickMove STOP;
    public GameObject camcanvas;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        a = true;
        //r = player.GetComponent<SpriteRenderer>().color.r;
    }

    // Update is called once per frame
    void Update()
    {
        if (a && tic.ticket)
        {
            cubewait.SetActive(true);
            player.transform.position = new Vector3(5.5f,20,-2);
            STOP.stop = true;
            camcanvas.SetActive(false);
            cam.transform.position = new Vector3(-20,24.45f,-10);
            a=false;
            StartCoroutine(wait());
            
        }

    }
    public IEnumerator wait()
    {
        //a = false;
        yield return new WaitForSeconds(5);
        cubewait.SetActive(false);
        cam.transform.position = new Vector3(0, 24.31f, -10);
        STOP.stop = false;
    }
}

