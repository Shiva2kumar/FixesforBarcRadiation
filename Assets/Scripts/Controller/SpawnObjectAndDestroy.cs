using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObjectAndDestroy : MonoBehaviour
{
    public HitObjectbyRayCast ColliderPhysics;
    public InventorySystem InventorySystem;
    public ControllerInputsManualBounds InputsPass;
    public bool ButtonPressR, ButtonPressL;
    [SerializeField] public Transform origin;
    [SerializeField] public GameObject Trollycar;
    public GameObject LastHit, LastHit2, Empty;
    public float FrameTimes = 0.1f;
    public Vector3 transformlocation = Vector3.zero;
    public int Num = 1;
    public float timeRemaining = 2;
    public bool IsSelected;

    public Hands selectedhands;
    public enum Hands
    {
        lefthand,
        righthand
    }

    private void Awake()
    {
        Empty = GameObject.Find("EmptyCollider");
    }
    // Start is called before the first frame update
    private void Start()
    {
        IsSelected = false;
        
    }
    public void Update()
    {
        //SendCollidedobject();
        ButtonPressR = InputsPass.B;
        ButtonPressL = InputsPass.Y;

        if (IsSelected == true)
        {
            Trollycar = GameObject.Find("Trollycar");
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 2;
            }

            if (timeRemaining <= 0.1f)
            {
                if (ButtonPressR == true)
                {
                    shooting();
                }
                else
                {

                }

                if (ButtonPressL == true)
                {
                    shooting();
                }
                else
                {

                }
            }
        }

        if (InventorySystem.LobbyorNot == true)
        {
            IsSelected = false;
        }
        else
        {
            IsSelected = true;
        }

    }
    // Update is called once per frame


    public void shooting()
    {
        var ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 2))
        {
            LastHit = (hit.transform.gameObject);
            transformlocation = hit.point;
            Trollycar.transform.position = Vector3.Lerp(Trollycar.transform.position, transformlocation, FrameTimes);
        }
    }

    public void SendCollidedobject()
    {
        var ray2 = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit2;
        if (Physics.Raycast(ray2, out hit2, 5f))
        {
            LastHit2 = (hit2.transform.gameObject);
        }

        if (selectedhands == Hands.lefthand)
        {
            ColliderPhysics.LCollidedobjectname = LastHit2.ToString();    
        }
        


        if (selectedhands == Hands.righthand)
        {
            ColliderPhysics.RColliderobjectname = LastHit2.ToString();
        }
        

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(this.transform.position, transform.forward);
    }

}
