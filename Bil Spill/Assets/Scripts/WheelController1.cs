using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController1 : MonoBehaviour
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
        currentAcceleration = acceleration * Input.GetAxis("Vertical2");

        backRight.motorTorque = currentAcceleration;
        backLeft.motorTorque = currentAcceleration;
    }

    public void Break()
    {
        if (Input.GetKey(KeyCode.Return))
            currentBreakForce = breakForce;
        else
            currentBreakForce = 0f;

        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;
    }

    public void Angle()
    {
        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal2");
        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;
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
