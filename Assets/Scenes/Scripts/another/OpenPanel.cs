using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    public GameObject panel;
    public GameObject platform;
    bool a = false;
    public ClickMove STOP;


    public void Open()
    {
        Debug.Log("111"); 

        a = !a;
        STOP.stop = a;
        platform.SetActive(!platform.activeSelf);
        panel.SetActive(!panel.activeSelf);

    }
    private void Update()
    {
        if (platform.activeSelf==false && panel.activeSelf==false)
        { 
        platform.SetActive(true);
        }

    }
}
