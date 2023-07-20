using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class deviceRID : MonoBehaviour
{   public float c=0.60f,c1=0.137f;
    public double dosecs137,dosecs60,both,FinalDose60,FinalDose137,FinalCombine;
    public float r,r1,i,j;
    public bool cs60;
    public bool cs137,RID;
    public TextMeshProUGUI RIDCS60,RIDCS137,combine;

    private void Start()
    {
        dosecs60 = 0;
        dosecs137 = 0;
        RID = false;
        InvokeRepeating("Rand", 2, 0.3F);
    }
    public void Rand()
    {
        i = Random.Range(0.05f, 0.1f);
        j = Random.Range(0.05f, 0.1f);
        if (RID == false)
        {
            dosecs60 = i;
            dosecs137 = j;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        RID = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (RID)
        {
            if (other.gameObject.tag == "cs60")
            {
                cs60 = true;
                r = Vector3.Distance(this.transform.position, other.gameObject.transform.position);
                dosecs60 = i+(12500 * 0.60 * ((Mathf.Exp(-7 ^ -3)) * r) / (r * r)) * 0.000001f;
                dosecs60 = Math.Round(dosecs60, 2, MidpointRounding.ToEven);
             //   FinalDose60 = dosecs60;
                if (dosecs60 > 0.2)
                {
                    FinalDose60 = dosecs60;
                    RIDCS60.text = "Co60= " + FinalDose60 + "µSv/h";
                }
                else
                {
                    dosecs60 = i;
                    RIDCS60.text = " ";
                }
            }
            else if (other.gameObject.tag == "cs137")
            {
                cs137 = true;
                r1 = Vector3.Distance(this.transform.position, other.gameObject.transform.position);
                dosecs137 = j+((2814 * 0.137 * (Mathf.Exp(-9 ^ -3) * r1) / (r1 * r1)) * 0.000001f);
                dosecs137 = Math.Round(dosecs137, 2, MidpointRounding.ToEven);
             //   FinalDose137 = dosecs137;
                if (dosecs137 > 0.2)
                {
             //       FinalCombine = FinalDose60 + FinalDose137;
              //      combine.text = FinalCombine.ToString();

                    FinalDose137 = dosecs137;
                    RIDCS137.text = "Cs137= " + FinalDose137 + "µSv/h";
                }
                else
                {
                    dosecs137 = j;
                    RIDCS137.text = " ";
                }
            }

            if(dosecs60>0.2&&dosecs137>0.2)
            {

                FinalCombine = FinalDose60 + FinalDose137;
                combine.text = FinalCombine.ToString();
            }


  /*       if (cs60 && cs137)
            {
          //      FinalCombine = FinalDose60 + FinalDose137;
         //       FinalCombine = Math.Round(both, 2, MidpointRounding.ToEven);
                if (FinalDose60 > 0.2)
                {
                    RIDCS60.text = FinalDose60 + "µSv/h";
                }
                if (FinalDose137 > 0.2)
                {
                    RIDCS137.text = FinalDose137 + "µSv/h";
                }
                if (FinalDose60 < 0.2)
                {
                    dosecs60 = i;
                }
                if (FinalDose137 < 0.2)
                {
                    dosecs137 = j;
                } 
                if (FinalCombine > 0.2)
                {
                    combine.text = FinalCombine.ToString();
                }
            }*/
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("cs60"))
        {
            dosecs60 = Random.Range(0.05f, 0.1f);
            cs60 = false;
            RIDCS60.text = " ";
        }
        else if (other.CompareTag("cs137"))
        {
            dosecs137 = Random.Range(0.05f, 0.1f);
            cs137 = false;
            RIDCS137.text = " ";
        }
    }
}
