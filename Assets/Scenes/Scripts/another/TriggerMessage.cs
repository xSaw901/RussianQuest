using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerMessage : MonoBehaviour
{
    public bool check=false;
    public Text text;
    public SetCursor cursor;


    //void Update()
    //{
    //    if (check == true && Input.GetKeyDown(KeyCode.E))
    //    {
    //        text.text = "������ ������";
    //    }
    //}
    private void OnMouseDown()
    {
        if (cursor.chek==true)
        {
            text.text = "������ ����������, ���� �� ������ ���� � ������ ������";
        }
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    check = true;

    //}
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    check=false;
    //    text.text = " ";
    //}
}
