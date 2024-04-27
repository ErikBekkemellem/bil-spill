using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarScene : MonoBehaviour
{
    void Update()
    {

        if (Input.GetButton("Restart1"))
        {
            SceneManager.LoadScene("SimplePoly City - Low Poly Assets_Demo Scene");
        }

        if (Input.GetButton("Restart2"))
        {
            SceneManager.LoadScene("SimplePoly City - Low Poly Assets_Demo Scene");
        }
    }
}
