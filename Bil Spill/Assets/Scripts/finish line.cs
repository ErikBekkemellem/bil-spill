using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishline : MonoBehaviour
{
    public bool checkPoint = false;
    public bool P1Mal = false;
    public bool P2Mal = false;

    bool P1Winner = false;
    bool P2Winner = false;

    


    private void Update()
    {
        if (P1Winner == true)
        {
            Debug.Log("P1 vant");
        }

        else if (P2Winner == true)
        {  
            Debug.Log("P2 vant");
        }
    }


    private void OnTriggerEnter(Collider target)
    {
       
 
        if (target.tag == "Finish Line" && checkPoint == true && gameObject.tag == "Player")
        {
            P1Mal = true;
        }

        if (target.tag == "Finish Line" && checkPoint == true && gameObject.tag == "Player2")
        {
            P2Mal = true;
        }

        if (target.tag == "Check Point")
        {
            checkPoint = true;
        }

        if (target.tag == "Finish Line" && P2Mal == true && P1Mal == false)
        {
            P2Winner = true;
        }

        if (target.tag == "Finish Line" && P1Mal == true && P2Mal == false)
        {
            P1Winner = true;
        }

    }
}
