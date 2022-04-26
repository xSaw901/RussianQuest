using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusFill : MonoBehaviour
{
    public bool Puzo = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Puzo = true;
    }
}
