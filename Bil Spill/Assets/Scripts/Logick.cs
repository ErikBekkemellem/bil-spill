using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logick : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            SceneManager.LoadScene("SimplePoly City - Low Poly Assets_Demo Scene");
        }
    }
}
