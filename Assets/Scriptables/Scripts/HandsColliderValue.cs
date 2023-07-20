using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "ColliderAsTextValue/ScriptableText", fileName = "ColliderValue", order = 0)]
public class HandsColliderValue : ScriptableObject
{
    public bool LeftActive, RightActive;
    public string LeftString, RightString, HandLTriggerdValue, HandRTriggerdValue;
    public enum LHand
    {
        none,
        Left,
        Right
    }

    public enum RHand
    {
        None,
        Left,
        Right
    }

    public LHand SelectedHandLeft;
    public RHand SelectedHandRight;
}
