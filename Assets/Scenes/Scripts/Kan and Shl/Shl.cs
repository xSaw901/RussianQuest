using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shl : MonoBehaviour
{
    public bool Shlang = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Shlang = true;
    }
}
