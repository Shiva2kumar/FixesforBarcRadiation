using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Linq;
using Random = UnityEngine.Random;
using Unity.VisualScripting;

public class deviceteletector : MonoBehaviour
{
  
    public float c = 0.60f, c1 = 0.137f;
    public double dosecs137, dosecs60, both,combine;
    public  float r, r1, variation,r2,r6;
    private bool cs60,TLD;
    private bool cs137;
    public float i, j;
    public TextMeshProUGUI radiation,distance;
    private void Start()
    {
        dosecs60 = 0;
        dosecs137 = 0;
           TLD = false;
    }
    private void Update()
    {

    i = Random.Range(0.05f, 0.1f);
    j = Random.Range(0.05f, 0.1f);

        if (cs60==false||cs137==false)
        {
            //    dosecs60 = i;
            //    dosecs60 = Math.Round(dosecs60, 2, MidpointRounding.ToEven);
            //  i = Math.Round(i, 3, MidpointRounding.ToEven);
        //    i = i.ConvertTo<float>();
           i = Mathf.Round(i * 100f)/100;
        //    i = Math.Round(i, 2, MidpointRounding.ToEven);
            radiation.text = i.ToString();
         //   dosecs137 = j;
        }
    


    }
    private void OnTriggerEnter(Collider other)
    {
        TLD = true;
    }
    public void OnTriggerStay(Collider other)
    {
        if (TLD)
        {
            if (other.gameObject.tag == "cs60")
            {
                r = Vector3.Distance(this.transform.position, other.gameObject.transform.position);
                cs60 = true;
                r = Vector3.Distance(this.transform.position, other.gameObject.transform.position);
                dosecs60 = i + (12500 * 0.60 * ((Mathf.Exp(-7 ^ -3)) * r) / (r * r)) * 0.000001f;
                dosecs60 = Math.Round(dosecs60, 2, MidpointRounding.ToEven);
                if (dosecs60 < 0.2f)
                {
                    radiation.text = dosecs60.ToString();
                }
            }
            if (other.gameObject.tag == "cs137")
            {
                cs137 = true;
                r1 = Vector3.Distance(this.transform.position, other.gameObject.transform.position);
                dosecs137 = j + (2814 * 0.137 * (Mathf.Exp(-9 ^ -3) * r1) / (r1 * r1)) * 0.000001f;
                dosecs137 = Math.Round(dosecs137, 2, MidpointRounding.ToEven);
                if (dosecs137 > 0.2f)
                {
                    radiation.text = dosecs137.ToString();
                }
            }
            if (dosecs137 > 0.2f)
            {
                radiation.text = dosecs137.ToString();
            }
            if (cs60 && cs137)
            {
                both = dosecs60 + dosecs137;
                both = Math.Round(both, 2, MidpointRounding.ToEven);
                radiation.text = both.ToString();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("cs60"))
        {
            dosecs60 = Random.Range(0.05f, 0.1f);
            cs60 = false;
        }
        else if (other.CompareTag("cs137"))
        {
            dosecs137 = Random.Range(0.05f, 0.1f);
            cs137 = false;
        }
    }
    }
