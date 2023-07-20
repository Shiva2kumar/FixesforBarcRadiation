using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetector : MonoBehaviour
{
    public InventorySystem INV;
    public void OnTriggerEnter(Collider other)
    {
        GameObject go = other.gameObject;
        if (go.name == "RID Variant 1(Clone)")
        {
            INV.RIDWorkingValue = true;
        }

        if (go.name == "RID Variant 2(Clone)")
        {
            INV.RIDBrokenValue = true;
        }

        if (go.name == "TLD Variant 1 Fix(Clone)")
        {
            INV.TLDworkingValue = true;
        }

        if (go.name == "TLD Variant 2 Fix(Clone)")
        {
            INV.TLDBrokenValue = true;
        }

        if (go.name == "DOD Variant(Clone)")
        {
            INV.DRDValue = true;
        }

        if (go.name == "DOD Variant 1(Clone)")
        {
            INV.DRDValue1 = true;
        }
    }


    public void OnTriggerStay(Collider other)
    {
        GameObject go = other.gameObject;
        if (go.name == "RID Variant 1(Clone)")
        {
            INV.RIDWorkingValue = true;
        }

        if (go.name == "RID Variant 2(Clone)")
        {
            INV.RIDBrokenValue = true;
        }

        if (go.name == "TLD Variant 1 Fix(Clone)")
        {
            INV.TLDworkingValue = true;
        }

        if (go.name == "TLD Variant 2 Fix(Clone)")
        {
            INV.TLDBrokenValue = true;
        }

        if (go.name == "DOD Variant(Clone)")
        {
            INV.DRDValue = true;
        }

        if (go.name == "DOD Variant 1(Clone)")
        {
            INV.DRDValue1 = true;
        }
    }


    public void OnTriggerExit(Collider other)
    {
        GameObject go = other.gameObject;
        if (go.name == "RID Variant 1(Clone)")
        {
            INV.RIDWorkingValue = false;
        }

        if (go.name == "RID Variant 2(Clone)")
        {
            INV.RIDBrokenValue = false;
        }

        if (go.name == "TLD Variant 1 Fix(Clone)")
        {
            INV.TLDworkingValue = false;
        }

        if (go.name == "TLD Variant 2 Fix(Clone)")
        {
            INV.TLDBrokenValue = false;
        }

        if (go.name == "DOD Variant(Clone)")
        {
            INV.DRDValue = false;
        }

        if (go.name == "DOD Variant 1(Clone)")
        {
            INV.DRDValue1 = false;
        }
    }
}
