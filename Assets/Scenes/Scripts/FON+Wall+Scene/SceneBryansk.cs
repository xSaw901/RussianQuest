using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBryansk : MonoBehaviour
{
    public CAR Compl;
    private void OnMouseDown()
    {
        if(Compl.complited)
            SceneManager.LoadScene(3);
    }
}
