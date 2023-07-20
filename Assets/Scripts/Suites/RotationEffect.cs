using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationEffect : MonoBehaviour
{
    public static RotationEffect Instance;
    public float Speed, AngularSpeed, Value;
    public Rigidbody body;
    public void FixedUpdate()
    {
        Instance = this;
        Speed = body.velocity.magnitude;
        AngularSpeed = body.angularVelocity.magnitude;
        body.maxAngularVelocity = Value;
        body.AddTorque(Vector3.up);
    }
}
