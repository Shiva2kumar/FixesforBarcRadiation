using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectIntractor : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform pickuppointL, pickuppointR;
    public float speed;
    public GameObject posi, stroredgameobject, storedobjectR, storedobjectL;
    public bool GrabLActive, GrabRActive;
    public string StringL, StringR;

    public HandsColliderValue handbjectValue;

    // Update is called once per frame
    void FixedUpdate()
    {
        StringL = handbjectValue.HandLTriggerdValue;
        StringR = handbjectValue.HandRTriggerdValue;

        storedobjectL = (GameObject)GameObject.Find(StringL);
        storedobjectR = (GameObject)GameObject.Find(StringR);


        IntractionSystem();
    }


    public void IntractionSystem()
    {

        if(HandsColliderValue.LHand.Left == handbjectValue.SelectedHandLeft)
        {
            if(storedobjectL.tag == "Grabbable")
            {
                //storedobjectL.transform.position = Vector3.Lerp(storedobjectL.transform.position, pickuppointL.transform.position, Time.deltaTime * speed);
            }
            else
            {

            }
        }
        else
        {
            //storedobjectL.transform.position = this.transform.position;
        }



        if (HandsColliderValue.RHand.Right == handbjectValue.SelectedHandRight)
        {
            if (storedobjectR.tag == "Grabbable")
            {
                //storedobjectR.transform.position = Vector3.Lerp(storedobjectR.transform.position, pickuppointR.transform.position, Time.deltaTime * speed);
            }
                
        
                
        }
        else
        {
            //storedobjectL.transform.position = this.transform.position;
        }
    }

    public void OnDisable()
    {
        handbjectValue.SelectedHandLeft = HandsColliderValue.LHand.none;
        handbjectValue.SelectedHandRight = HandsColliderValue.RHand.None;
    }
}
