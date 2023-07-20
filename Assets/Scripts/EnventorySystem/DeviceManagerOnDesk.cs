using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceManagerOnDesk : MonoBehaviour
{
    public InventorySystem Inventory;
    public GameManager GameManager;
    public void Start()
    {
        Inventory.RIDWorkingValue = false;
        Inventory.RIDBrokenValue = false;
        Inventory.TLDworkingValue = false;
        Inventory.TLDBrokenValue = false;
        Inventory.DRDValue = false;
        Inventory.Gloves = false;
        Inventory.Mask = false;
        Inventory.BoilerSuite = false;
        Inventory.Boots = false;
        Inventory.ShoeCover = false;
        Inventory.Tong = false;
    }


    public void FixedUpdate()
    {
        
        if(GameManager.destroyGlove == true)
        {
            Inventory.Gloves = true;
        }
        if (GameManager.destroymask == true)
        {
            Inventory.Mask = true;
        }
        if (GameManager.destroysuite == true)
        {
            Inventory.BoilerSuite = true;
        }
        if (GameManager.destroyBoots == true)
        {
            Inventory.Boots = true;
        }
        if (GameManager.destroycover == true)
        {
            Inventory.ShoeCover = true;
        }
        
    }

}
