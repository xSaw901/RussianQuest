using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kan : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Kanistr = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Kanistr = true;
    }
    }
