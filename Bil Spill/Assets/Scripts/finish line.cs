using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishline : MonoBehaviour
{
    public bool checkPoint = false;


    private void Update()
    {
        
    }


    private void OnTriggerEnter(Collider target)
    {

        if (target.tag == "Check Point")
        {
            checkPoint = true;
        }
    }
}
