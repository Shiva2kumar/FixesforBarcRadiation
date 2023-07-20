using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Inventory system",menuName = "Scriptables/InventorySystem/Inventory",order = 0)]
public class InventorySystem : ScriptableObject
{
    public bool RIDWorkingValue, RIDBrokenValue, TLDworkingValue, TLDBrokenValue, DRDValue, DRDValue1;
    public bool Gloves, Mask, BoilerSuite, Boots, ShoeCover, Tong;
    public bool LobbyorNot, TrollyCarSelected;
}
