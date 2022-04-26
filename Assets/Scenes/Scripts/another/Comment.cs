using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comment : MonoBehaviour
{
    public SetCursor CHEK;
    public string PisatSuda;
    public Text DialogWindow;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
         
    }
    private void OnMouseDown()
    {
        if (CHEK.chek)
        {
            DialogWindow.text = PisatSuda;
            
        }

    }
    public IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);
        DialogWindow.text = "";
        //Schet--;
    }
}
