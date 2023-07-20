using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Random = UnityEngine.Random;
public class DRDoperator : MonoBehaviour
{ 
    public float c = 0.60f, c1 = 0.137f,a;
    public Vector3 obj,obj2;
    public double dosecs137, dosecs60, both, dosecs602nd,dosecs1372nd,Dose_60,Dose_137,Dose_602nd,Dose_1372nd;
    public double Finaldose60,Finaldose137,Final_dose60,Final_dose137;
    public float r, r1,r2,r3,i,j;
    private bool cs60,DRD;
    private bool cs137;
    public TextMeshProUGUI DRDcs60,DRDcs137,DRDradiation,dose_60,dose_137;



    private void Start()
    {
        dosecs60 = 0;
        dosecs137 = 0;
        DRD = false;
    }
    private void Update()
    {
        i = Random.Range(0.05f, 0.1f);
        j = Random.Range(0.05f, 0.1f);

        if (DRD==false)
        {
            dosecs60 = i;
            dosecs137 = j;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        DRD = true;
    }
    private void OnTriggerStay(Collider other)
    {
        if (DRD) { 

        if (other.gameObject.tag=="cs60")
        {
            Stack mystack = new Stack();
            cs60 = true;
            if (mystack.Count == 0)
            {
                r = Vector3.Distance(this.transform.position, other.gameObject.transform.position);
                dosecs60 = (12500 * 0.60 * ((Mathf.Exp(-7 ^ -3)) * r) / (r * r)) * 0.000001f;

                    Dose_60 = ((2814 * c) / (r * r))* 0.000001;
            }
            mystack.Push(r);
            if (mystack.Count == 1)
            {  
                StartCoroutine(calc());
                obj = other.gameObject.transform.position;
            }
        }
            if (other.gameObject.tag == "cs137")
            {
                cs137 = true;
                Stack cs = new Stack();
                if (cs.Count == 0)
                {
                    r2 = Vector3.Distance(this.transform.position, other.gameObject.transform.position);
                    dosecs137 = (2814 * 0.137 * (Mathf.Exp(-9 ^ -3) * r2) / (r2 * r2)) * 0.000001f;
                    Dose_137=(12500*c)/(r2* r2)* 0.000001;

                }
                cs.Push(r2);
                if (cs.Count == 1)
                {
                    StartCoroutine(ndCalc());
                    obj2 = other.gameObject.transform.position;
                }

                if (cs60 && cs137)
                {
                    both = Finaldose60 + Finaldose137;
                    both = Math.Round(both, 2, MidpointRounding.ToEven);
                    DRDradiation.text = both.ToString()+ "µSv/h";
                }
            }
        }
    }
    public IEnumerator calc()
    {
        yield return new WaitForSeconds(1);
            r3 = Vector3.Distance(this.transform.position-new Vector3(0,0,0.5f), obj);
        dosecs602nd = (12500 * 0.60 * ((Mathf.Exp(-7 ^ -3)) * r3) / (r3 * r3)) * 0.000001f;
        Finaldose60 =i+ (dosecs60 + dosecs602nd)* 0.27;
        Finaldose60 = Math.Round(Finaldose60, 4, MidpointRounding.ToEven);
        //   DRDcs60.text = Finaldose60 + "µSv/h";
        DRDradiation.text = Finaldose60 + "µSv/h";
        //dose_60.text = Dose_60 + "µSv/h";
    }
    public IEnumerator ndCalc()
    {
        yield return new WaitForSeconds(1);
        r1 = Vector3.Distance(this.transform.position - new Vector3(0, 0, 0.5f), obj2);
        dosecs1372nd = (2814 * 0.137 * (Mathf.Exp(-9 ^ -3) * r1) / (r1 * r1)) * 0.000001f;
        Finaldose137 = j+(dosecs137 + dosecs1372nd) * 0.27;
        Finaldose137 = Math.Round(Finaldose137, 4, MidpointRounding.ToEven);
        DRDradiation.text = Finaldose137 + "µSv/h";
       // dose_137.text=Dose_137+ "µSv/h";
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("cs60"))
        {
            Finaldose60 = Random.Range(0.05f, 0.1f);
            cs60 = false;
        }
        else if (other.CompareTag("cs137"))
        {
            Finaldose137 = Random.Range(0.05f, 0.1f);
            cs137 = false;
        }
    }
}