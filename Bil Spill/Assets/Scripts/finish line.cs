using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishline : MonoBehaviour
{
    
    public bool P1Mal = false;
    public bool P2Mal = false;

    bool P1Winner = false;
    bool P2Winner = false;

    public Check chack;

    public brombrom Player2Script;
    public NewBehaviourScript Player1Script;


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


    void OnTriggerEnter(Collider target)
    {
       
 
        if (chack.checkPoint == true && target.gameObject.tag == "Player")
        {
            P1Mal = true;
        }

        if (chack.checkPoint == true && target.gameObject.tag == "Player2")
        {
            P2Mal = true;
        }

        if (target.gameObject.tag == "Player2" && P2Mal == true && P1Mal == false)
        {
            P2Winner = true;
        }

        if (target.gameObject.tag == "Player" && P1Mal == true && P2Mal == false)
        {
            P1Winner = true;
        }

    }
    
}
