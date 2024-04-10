using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finishline : MonoBehaviour
{
    
    public bool P1Mal = false;
    public bool P2Mal = false;

    bool P1Winner = false;
    bool P2Winner = false;

    public Check chack;

    public brombrom Player2Script;
    public NewBehaviourScript Player1Script;

    public GameObject P1Win;
    public GameObject P2Win;


    private void Update()
    {
        if (P1Winner == true && P2Mal == true)
        {
            P1Win.SetActive(true);

        }

        else if (P2Winner == true && P1Mal == true)
        {
            P2Win.SetActive(true);
        }
    }


    void OnTriggerEnter(Collider target)
    {
       
 
        if (chack.checkPointP1 == true && target.gameObject.tag == "Player")
        {
            P1Mal = true;
            Player1Script.winnerWinnerChickenDinner = true;
            
        }

        if (chack.checkPointP2 == true && target.gameObject.tag == "Player2")
        {
            P2Mal = true;
            Player2Script.winnerWinnerChickenDinner = true;
            
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
