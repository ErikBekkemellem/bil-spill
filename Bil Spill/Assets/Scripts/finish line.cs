using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishline : MonoBehaviour
{
    public bool checkPoint = false;
    public bool P1Mål = false;
    public bool P2Mål = false;

    bool P1Winner = false;
    bool P2Winner = false;

    


    private void Update()
    {
        if (P1Winner == true)
        {
            Debug.Log("P2 vant");
        }

        else if (P2Winner == true)
        {  
            Debug.Log("P1 vant");
        }
    }


    private void OnTriggerEnter(Collider target)
    {
       
 
        if (target.tag == "Finish Line" && checkPoint == true && gameObject.tag == "Player")
        {
            P1Mål = true;
        }

        if (target.tag == "Finish Line" && checkPoint == true && gameObject.tag == "Player2")
        {
            P2Mål = true;
        }

        if (target.tag == "Check Point")
        {
            checkPoint = true;
        }

        if (target.tag == "Finish Line" && P2Mål == true && P1Mål == false)
        {
            P1Winner = true;
        }

        if (target.tag == "Finish Line" && P1Mål == true && P2Mål == false)
        {
            P2Winner = true;
        }
    }
}
