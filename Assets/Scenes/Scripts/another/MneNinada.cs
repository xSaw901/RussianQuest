using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MneNinada : MonoBehaviour
{
    public Text txt;
    public ClickMove STOP;
    public bool a=false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        STOP.stop = true;
        txt.text = "Мне туда нинада";
        StartCoroutine(wait());
    }
    public IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
        STOP.stop = false;
        txt.text = " ";
    }
}
