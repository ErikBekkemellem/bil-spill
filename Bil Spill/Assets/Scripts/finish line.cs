using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishline : MonoBehaviour
{
    public bool checkPoint = false;
    public bool P1Vant = false;
    public bool P2Vant = false;

    public GameObject Enemy;


    private void Update()
    {
        if (P1Vant == true)
        {

        }

        if (P2Vant == true)
        {

        }
    }


    private void OnTriggerEnter(Collider target)
    {
        /*
        if(target.tag == "Finish Line" && gameObject.tag == "Player" && checkPoint == true)
        {
            Enemy.tag = "Looser";
        }
        */
        if (target.tag == "Finish Line" && checkPoint == true && gameObject.tag == "Player")
        {
            P1Vant = true;
        }

        if (target.tag == "Finish Line" && checkPoint == true && gameObject.tag == "Player2")
        {
            P2Vant = true;
        }

        if (target.tag == "Check Point")
        {
            checkPoint = true;
        }
        /*
        if(target.tag == "Finish Line" && gameObject.tag == "Looser" && P2)
        {
            Debug.Log("P1 vant");
        }

        if (target.tag == "Finish Line" && gameObject.tag == "Looser" && P1)
        {
            Debug.Log("P2 vant");
        }
        */
    }
}
