using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    void Update()
    {

        if (Input.GetButton("Restart1") || Input.GetButton("Restart2"))
        {
            SceneManager.LoadScene("StartSceneVaca");
        }
    }

    
}
