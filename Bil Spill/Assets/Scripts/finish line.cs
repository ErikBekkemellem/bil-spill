using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishline : MonoBehaviour
{
    public bool checkPoint = false;
    public bool P1M�l = false;
    public bool P2M�l = false;

    bool P1Winner = false;
    bool P2Winner = false;

    int playerFinished = 0;


    private void Update()
    {
        if (P1Winner == true)
        {

        }

        if (P2Winner == true)
        {

        }
    }


    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Finish Line" && checkPoint == true)
        {
            playerFinished ++;
        }
 
        if (target.tag == "Finish Line" && checkPoint == true && gameObject.tag == "Player")
        {
            P1M�l = true;
        }

        if (target.tag == "Finish Line" && checkPoint == true && gameObject.tag == "Player2")
        {
            P2M�l = true;
        }

        if (target.tag == "Check Point")
        {
            checkPoint = true;
        }

        if (target.tag == "Finish Line" && checkPoint == true && P2M�l == true && P1M�l == false)
        {
            P1Winner = true;
        }

        if (target.tag == "Finish Line" && checkPoint == true && P1M�l == true && P2M�l == false)
        {
            P2Winner = true;
        }
    }
}
