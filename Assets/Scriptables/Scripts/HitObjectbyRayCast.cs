using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RaycastSystem", menuName = "Scriptables/RaycastSystem/RaycastValues", order = 0)]
public class HitObjectbyRayCast : ScriptableObject
{
    public GameObject LCollidedobject, RColliderObject;
    public string LCollidedobjectname, RColliderobjectname;
}
