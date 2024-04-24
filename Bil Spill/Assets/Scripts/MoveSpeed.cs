using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpeed : MonoBehaviour
{
    private float speed;


    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CalculateSpeed());
    }

    IEnumerator CalculateSpeed()
    {
        Vector3 lastPosition = transform.position;
        yield return new WaitForFixedUpdate();
        speed = (lastPosition - transform.position).magnitude / Time.deltaTime;
    }
}
