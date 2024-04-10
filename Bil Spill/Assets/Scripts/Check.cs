using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    public bool checkPointP1 = false;
    public bool checkPointP2 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag == "Player2")
        {
            checkPointP2 = true;
        }

        if (target.gameObject.tag == "Player")
        {
            checkPointP1 = true;
        }
    }
}
