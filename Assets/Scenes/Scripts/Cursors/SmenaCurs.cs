using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmenaCurs : MonoBehaviour
{
    public Texture2D cursorTexture;
    public Texture2D StartCursor;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    public SetCursor CHEK;
    private void OnMouseEnter()
    {
        if(CHEK.chek==false) 
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    private void OnMouseExit()
    {
        if (CHEK.chek == false)
            Cursor.SetCursor(StartCursor, hotSpot, cursorMode);
    }
}
