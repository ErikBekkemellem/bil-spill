using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;

    [SerializeField] Transform frontLeftTransform;
    [SerializeField] Transform frontRightTransform;
    [SerializeField] Transform backRightTransform;
    [SerializeField] Transform backLeftTransform;

    public float acceleration = 500f;
    public float breakForce = 300f;
    public float maxTurnAngle = 15f;

    private float currentAcceleration = 0f;
    private float currentBreakForce = 0f;
    private float currentTurnAngle = 0f;


    private void FixedUpdate()
    {
        Acceleration();
        Break();
        Angle();

        UpdateWheel(frontLeft, frontLeftTransform);
        UpdateWheel(frontRight, frontRightTransform);
        UpdateWheel(backLeft, backLeftTransform);
        UpdateWheel(backRight, backRightTransform);
    }

    public void Acceleration()
    {
        currentAcceleration = acceleration * 100 * Input.GetAxis("Vertical1");

        frontRight.motorTorque = currentAcceleration;
        frontLeft.motorTorque = currentAcceleration;
    }

    public void Break()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            currentBreakForce = breakForce * Time.deltaTime;
        }
        else
        {
            currentBreakForce = 0f;
        }

        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;
    }

    public void Angle()
    {
    
        currentTurnAngle = Input.GetAxis("Horizontal1") * maxTurnAngle;
        
        frontLeft.steerAngle = Mathf.LerpAngle(currentTurnAngle, currentTurnAngle, 0.6f);
        frontRight.steerAngle = Mathf.LerpAngle(currentTurnAngle, currentTurnAngle, 0.6f);
    }

    void UpdateWheel(WheelCollider col, Transform trans)
    {
        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation);

        trans.position = position;
        trans.rotation = rotation;
    }
}
