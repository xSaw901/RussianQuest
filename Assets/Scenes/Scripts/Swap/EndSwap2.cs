using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndSwap2 : MonoBehaviour
{
    public GameObject cam;
    public GameObject camcanvas;
    public GameObject player;
    public GameObject[] e1= new GameObject[3];
    public GameObject titr;
    public GameObject txtcanvas;
    public GameObject sound2;
    public GameObject sound1;

    int i = 0; 
    bool gg=false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        sound2.SetActive(false);
        sound1.SetActive(true);
        cam.transform.position = new Vector3(0,12.97f,-10);
        camcanvas.SetActive(false);
        player.SetActive(false);
        StartCoroutine(wait());
        

    }
    private void Update()
    {
        if (gg)
        {
            titr.transform.position = new Vector3(titr.transform.position.x, titr.transform.position.y + 1, transform.position.z);
            if (titr.transform.position.y > 697f)
            {
                SceneManager.LoadScene(0);
                sound1.SetActive(false);
            }
                
        }
    }
    public IEnumerator wait()
    {
        yield return new WaitForSeconds(4);
        e1[i].SetActive(true);
        i++;
        yield return new WaitForSeconds(4);
        e1[i].SetActive(true);
        i++;
        yield return new WaitForSeconds(4);
        e1[i].SetActive(true);
        i++;
        yield return new WaitForSeconds(4);
        gg = true;
        txtcanvas.SetActive(true);


    }
    //public IEnumerator wait2()
    //{
    //    yield return new WaitForSeconds(10);

    //}
}
