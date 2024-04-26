using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public brombrom Player2Script;
    public NewBehaviourScript Player1Script;

    public int countdownTime;
    public Text countdownDisplay;

    public AudioSource playerAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDownTilStart());
    }

    IEnumerator CountDownTilStart() 
    {
        while(countdownTime > 0) 
        { 
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime -- ;

        }

        playerAudioSource.Play();

        countdownDisplay.text = "GO!";

        Player2Script.CanDriveP2 = true;
        Player1Script.CanDriveP1 = true;

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);
    }

}
