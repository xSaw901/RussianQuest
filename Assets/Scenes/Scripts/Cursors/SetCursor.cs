using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetCursor : MonoBehaviour
{
    public Texture2D cursorTexture;
    public Texture2D StartCursor;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    public bool chek = false;
    public ClickMove STOP;
    public GameObject lupa;
    public GameObject Platf,Platf2;
    public Sprite lupatrue;
    public Sprite lupafalse;
    public Text DialogWindow;
    public void Start()
    {
        Cursor.SetCursor(StartCursor,hotSpot,cursorMode);
    }
    public void Awake()
    {
        Platf = GameObject.FindWithTag("Platform");
        Platf2 = GameObject.FindWithTag("Platform1");
    }


    public void OnMouseDown()
    {
        STOP.stop = true;
        Platf.SetActive(false);
        Platf2.SetActive(false);
        //проверка взята лупа или нет
        chek = !chek;
        //если лупа не взята, то курсор меняется, если взята то меняется на стандартный
        if (chek == true)
        {
            lupa.GetComponent<SpriteRenderer>().sprite= lupatrue;
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);

        }
        else
        {
            lupa.GetComponent<SpriteRenderer>().sprite = lupafalse;
            Cursor.SetCursor(StartCursor, hotSpot, cursorMode);
            DialogWindow.text = "";
            StartCoroutine(Wait());


        }
        
        IEnumerator Wait()
        { 
        yield return new WaitForSeconds(0.1f);
            STOP.stop = false;
            Platf.SetActive(true);
            Platf2.SetActive(true);
        }
    }
    
}
