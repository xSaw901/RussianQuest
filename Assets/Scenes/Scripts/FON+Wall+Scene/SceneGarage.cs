using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGarage : MonoBehaviour
{
    public int i;
    private Vector3 PlayerPosition;
    public GameObject Player;
    // Start is called before the first frame update
    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (i)
        {
            case 0: PlayerPosition = new Vector3(-41.17f, -2.21f, -5f);
                break;
            case 1: PlayerPosition = new Vector3(-29.36f, -6.23f, 0f);
                break;
        }
        Player.transform.position = PlayerPosition;
        if(i==0)
        {

        }
        SceneManager.LoadScene(i);
        
    }
}
