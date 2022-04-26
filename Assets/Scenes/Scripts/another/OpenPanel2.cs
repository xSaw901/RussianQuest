using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel2 : MonoBehaviour
{
    public GameObject panel;
    public GameObject platform;
    bool a = false;
    public ClickMove STOP;
    private void OnMouseDown()
    {
        a = !a;
        STOP.stop = a;
        platform.SetActive(!platform.activeSelf);
        panel.SetActive(!panel.activeSelf);
    }
}
