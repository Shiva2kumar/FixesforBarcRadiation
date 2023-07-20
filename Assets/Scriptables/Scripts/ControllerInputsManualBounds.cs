using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Oculus Inputs", menuName = "Scriptables/Oculus InputSystem/ControllerInputs", order = 0)]
public class ControllerInputsManualBounds : ScriptableObject
{
    public float leftFloat, rightFloat;
    public bool A, X, B, Y;
}
