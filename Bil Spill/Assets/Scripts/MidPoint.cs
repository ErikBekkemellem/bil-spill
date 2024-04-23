using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidPoint : MonoBehaviour
{

    public GameObject YellowCar;
    public GameObject BlueCar;

    public GameObject Listener;

    // Update is called once per frame
    void Update()
    {
        Vector3 MiddlePosition = Vector3.Lerp(YellowCar.transform.position, BlueCar.transform.position, 0.5f);

        Listener.transform.position = MiddlePosition;
    }
}
