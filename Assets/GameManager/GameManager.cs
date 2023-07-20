using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public BoolsForDeviceProperties BoolsRID;
    public GameObject OVRplayer, OvrSpawnner;
    public Vector3 SpawnLocation;
    public HandsColliderValue ControllerTrigger;
    public GameObject PrefabGlove, PrefabBoots, PrefabSuite, PrefabMask, PrefabCover;

    public GameObject spawnglove, spawnboots, spawnsuite, spawnmask, spawncover;

    public bool destroyGlove, destroyBoots, destroysuite, destroymask, destroycover;

    public bool Lobby, HandTriggerActive;

    //public TouchTrigger[] trigger;

    public int RangesRID, RangeTLD, RangeDOD;

    public GameObject RID1, RID2, TLD1, TLD2, DOD, DOD1, TrollyCar;
    public GameObject PrefabRID1, PrefabRID2, PrefabTLD1, PrefabTLD2, PrefabDOD, PrefabDOD1, PrefabTrollyCar;

    public Vector3 RID1Location, RID2Location, TLD1Location, TLDLocation2, DODLocation, DOD1Location, TrollyCarLocation, RID1Rotaion, RID2Rotaion, TLD1Rotation, TLD2Rotaion, DODrotaion, DOD1Rotation, TrollyCarRotation;

    public InventorySystem Inventory_System;

    public string Maintext;


    [Header("Prefabs Spawn in game")]
    public GameObject RidDev1, RidDev2, TldDev1, TldDev2, DODDev, DODDev1;
    public Vector3 RidDev1Loc, RidDev2Loc, TldDev1Loc, TldDev2Loc, DODDevLoc, RidDev1Rot, RidDev2Rot, TldDev1Rot, TldDev2Rot, DODDevRot, DODDevloc1, DODDevrot1;
    private void OnEnable()
    {
        //BoolsRID.tld1 = false;
        //BoolsRID.tld2 = false;
        //BoolsRID.rid1 = false;
        //BoolsRID.rid2 = false;
        ABC();
        
    }

    public void ABC()
    {
        RangesRID = Random.Range(0, 9);
        RangeTLD = Random.Range(0, 10);
        RangeDOD = Random.Range(0, 10);
    }
    public void Start()
    {
        
        Instance = this;
        OvrSpawnner = Instantiate(OVRplayer, new Vector3(SpawnLocation.x, SpawnLocation.y, SpawnLocation.z), Quaternion.identity);
        mainDevicesSpawner();

        if (Lobby == true)
        {
            BoolsRID.tld1 = false;
            BoolsRID.tld2 = false;
            BoolsRID.rid1 = false;
            BoolsRID.rid2 = false;

            Inventory_System.LobbyorNot = true;
            Inventory_System.DRDValue1 = false;

            if (RangesRID == 2 || RangesRID == 4 || RangesRID == 6 || RangesRID == 8)
            {
                BoolsRID.tld1 = true;
                //BoolsRID.tld2 = false;
            }
            else if (RangesRID == 0 || RangesRID == 1 || RangesRID == 3 || RangesRID == 5 || RangesRID == 7 || RangesRID == 9)
            {
                //BoolsRID.tld1 = false;
                BoolsRID.tld2 = true;
            }
            else
            {
                BoolsRID.tld1 = false;
            }

            if (RangeTLD == 0 || RangeTLD == 1 || RangeTLD == 3 || RangeTLD == 5 || RangeTLD == 7 || RangeTLD == 9)
            {
                BoolsRID.rid1 = true;
                //BoolsRID.rid2 = false;
            }
            else if (RangeTLD == 2 || RangeTLD == 4 || RangeTLD == 6 || RangeTLD == 8 || RangeTLD == 10)
            {
                //BoolsRID.rid1 = false;
                BoolsRID.rid2 = true;
            }
            else
            {
                BoolsRID.rid1 = false;
            }


            if (RangeDOD == 0 || RangeDOD == 1 || RangeDOD == 3 || RangeDOD == 5 || RangeDOD == 7 || RangeDOD == 9)
            {
                BoolsRID.DOD = true;
                //BoolsRID.rid2 = false;
            }
            else
            {
                BoolsRID.DOD = false;
            }
            if (RangeDOD == 2 || RangeDOD == 4 || RangeDOD == 6 || RangeDOD == 8 || RangeDOD == 10)
            {
                //BoolsRID.rid1 = false;
                BoolsRID.DOD1 = true;
            }
            else
            {
                BoolsRID.DOD1 = false;
            }

        }
        else
        {
            Lobby = false;
            Inventory_System.LobbyorNot = true;
        }

        if (Lobby == true)
        {
            spawnglove = Instantiate(PrefabGlove, new Vector3(-2.769f, 1.05f, 35.70402f), Quaternion.Euler(0f, 90f, 0f));
            spawnboots = Instantiate(PrefabBoots, new Vector3(-2.769f, 1.078f, 36.83812f), Quaternion.Euler(0f, 90f, 0f));
            spawnsuite = Instantiate(PrefabSuite, new Vector3(-2.769f, 1.078f, 38.41012f), Quaternion.Euler(0f, 90f, 0f));
            spawnmask = Instantiate(PrefabMask, new Vector3(-2.769f, 1.078f, 39.93212f), Quaternion.Euler(0f, 90f, 0f));
            spawncover = Instantiate(PrefabCover, new Vector3(-2.769f, 1.078f, 41.59412f), Quaternion.Euler(0f, 90f, 0f));
        }


        if (Lobby == false)
        {
            Invoke("spawnObjectsingame", 2);
        }

    }

    public void OnDisable()
    {
        Destroy(OvrSpawnner);
    }

    public void FixedUpdate()
    {
        controllertriggerforequipment();
        if (Lobby == true)
        {
            if (destroyGlove == true)
            {
                Destroy(spawnglove);
            }

            if (destroyBoots == true)
            {
                Destroy(spawnboots);
            }

            if (destroysuite == true)
            {
                Destroy(spawnsuite);
            }

            if (destroymask == true)
            {
                Destroy(spawnmask);
            }

            if (destroycover == true)
            {
                Destroy(spawncover);
            }

            triggeractivate();
            CheckandDestroy();
        }

        if (Lobby == false)
        {

        }

    }




    public void triggeractivate()
    {/*
        if (trigger[0].activate == true)
        {
            destroyGlove = true;
        }

        if (trigger[1].activate == true)
        {
            destroyBoots = true;
        }

        if (trigger[2].activate == true)
        {
            destroysuite = true;
        }

        if (trigger[3].activate == true)
        {
            destroymask = true;
        }

        if (trigger[4].activate == true)
        {
            destroycover = true;
        }*/


        if (ControllerTrigger.LeftString == "Gloves" || ControllerTrigger.RightString == "Gloves")
        {
            if (ControllerTrigger.LeftActive == true || ControllerTrigger.RightActive == true)
            {
                destroyGlove = true;
            }
        }

        if (ControllerTrigger.LeftString == "Boot" || ControllerTrigger.RightString == "Boot")
        {
            if (ControllerTrigger.LeftActive == true || ControllerTrigger.RightActive == true)
            {
                destroyBoots = true;
            }
        }

        if (ControllerTrigger.LeftString == "Suite" || ControllerTrigger.RightString == "Suite")
        {
            if (ControllerTrigger.LeftActive == true || ControllerTrigger.RightActive == true)
            {
                destroysuite = true;
            }
        }

        if (ControllerTrigger.LeftString == "Mask" || ControllerTrigger.RightString == "Mask")
        {
            if (ControllerTrigger.LeftActive == true || ControllerTrigger.RightActive == true)
            {
                destroymask = true;
            }
        }

        if (ControllerTrigger.LeftString == "Cover" || ControllerTrigger.RightString == "Cover")
        {
            if (ControllerTrigger.LeftActive == true || ControllerTrigger.RightActive == true)
            {
                destroycover = true;
            }
        }
    }




    public void mainDevicesSpawner()
    {
        if (Lobby == true)
        {
            PrefabRID1 = Instantiate(RID1, new Vector3(RID1Location.x, RID1Location.y, RID1Location.z), Quaternion.Euler(RID1Rotaion.x, RID1Rotaion.y, RID1Rotaion.z));
            PrefabRID2 = Instantiate(RID2, new Vector3(RID2Location.x, RID2Location.y, RID2Location.z), Quaternion.Euler(RID2Rotaion.x, RID2Rotaion.y, RID2Rotaion.z));
            PrefabTLD1 = Instantiate(TLD1, new Vector3(TLD1Location.x, TLD1Location.y, TLD1Location.z), Quaternion.Euler(TLD1Rotation.x, TLD1Rotation.y, TLD1Rotation.z));
            PrefabTLD2 = Instantiate(TLD2, new Vector3(TLDLocation2.x, TLDLocation2.y, TLDLocation2.z), Quaternion.Euler(TLD2Rotaion.x, TLD2Rotaion.y, TLD2Rotaion.z));
            PrefabDOD = Instantiate(DOD, new Vector3(DODLocation.x, DODLocation.y, DODLocation.z), Quaternion.Euler(DODrotaion.x, DODrotaion.y, DODrotaion.z));
            PrefabDOD1 = Instantiate(DOD1, new Vector3(DOD1Location.x, DOD1Location.y, DOD1Location.z), Quaternion.Euler(DOD1Rotation.x, DOD1Rotation.y, DOD1Rotation.z));
            PrefabTrollyCar = Instantiate(TrollyCar, new Vector3(TrollyCarLocation.x, TrollyCarLocation.y, TrollyCarLocation.z), Quaternion.Euler(TrollyCarRotation.x, TrollyCarRotation.y, TrollyCarRotation.z));
        }
        else
        {

        }

    }

    public void CheckandDestroy()
    {
        if (Inventory_System.RIDWorkingValue == true)
        {
            //Destroy(PrefabRID1);
        }

        if (Inventory_System.RIDBrokenValue == true)
        {
            //Destroy(PrefabRID2);
        }

        if (Inventory_System.TLDworkingValue == true)
        {
            //Destroy(PrefabTLD1);
        }

        if (Inventory_System.TLDBrokenValue == true)
        {
            //Destroy(PrefabTLD2);
        }

        if (Inventory_System.DRDValue == true)
        {
            //Destroy(PrefabDOD);
        }


    }

    public void spawnObjectsingame()
    {
        if (Inventory_System.RIDWorkingValue == true)
        {
            RidDev1 = Instantiate(RID1, new Vector3(RidDev1Loc.x, RidDev1Loc.y, RidDev1Loc.z), Quaternion.Euler(RidDev1Rot.x, RidDev1Rot.y, RidDev1Rot.z));
        }
        else { Destroy(RidDev1); }


        if (Inventory_System.RIDBrokenValue == true)
        {
            RidDev2 = Instantiate(RID2, new Vector3(RidDev2Loc.x, RidDev2Loc.y, RidDev2Loc.z), Quaternion.Euler(RidDev2Rot.x, RidDev2Rot.y, RidDev2Rot.z));
        }
        else { Destroy(RidDev2); }


        if (Inventory_System.TLDworkingValue == true)
        {
            TldDev1 = Instantiate(TLD1, new Vector3(TldDev1Loc.x, TldDev1Loc.y, TldDev1Loc.z), Quaternion.Euler(TldDev1Rot.x, TldDev1Rot.y, TldDev1Rot.z));
        }
        else
        {
            Destroy(TldDev1);
        }

        if (Inventory_System.TLDBrokenValue == true)
        {
            TldDev2 = Instantiate(TLD2, new Vector3(TldDev2Loc.x, TldDev2Loc.y, TldDev2Loc.z), Quaternion.Euler(TldDev2Rot.x, TldDev2Rot.y, TldDev2Rot.z));
        }
        else
        {
            Destroy(TldDev2);
        }

        if (Inventory_System.DRDValue == true)
        {
            DODDev = Instantiate(DOD, new Vector3(DODDevLoc.x, DODDevLoc.y, DODDevLoc.z), Quaternion.Euler(DODDevRot.x, DODDevRot.y, DODDevRot.z));
        }
        else
        {
            Destroy(DODDev);
        }

        if (Inventory_System.DRDValue1 == true)
        {
            DODDev1 = Instantiate(DOD1, new Vector3(DODDevloc1.x, DODDevloc1.y, DOD1Location.z), Quaternion.Euler(DODDevrot1.x, DODDevrot1.y, DODDevrot1.z));
        }
        else
        {
            Destroy(DODDev1);
        }
    }


    public void controllertriggerforequipment()
    {
        if (ControllerTrigger.LeftActive == true)
        {
            HandTriggerActive = true;
        }
        else if (ControllerTrigger.RightActive == true)
        {
            HandTriggerActive = true;
        }
        else
        {
            HandTriggerActive = false;
        }
    }


    public void OnDestroy()
    {
        
    }

}
