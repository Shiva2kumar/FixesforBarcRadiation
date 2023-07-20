using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

//using Unity


public class raycheck : MonoBehaviour
{
    public float r;
    public AudioClip clip;
    public AudioSource source;
    // [SerializeField] public Text Texts;
    //   public TextMeshPro textbox;
    public TextMeshProUGUI yourtext;
    public void Raycastsingle()
    {
        float maxdistance = 5f;
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;
        Debug.DrawRay(origin, direction * 2f, Color.black);                      //0.16
        Ray ray = new Ray(origin, direction);

        RaycastHit hitInfo;
        bool result = Physics.Raycast(ray, out hitInfo, maxdistance);


        


        if(result)
        {
            if (hitInfo.collider.name == "one")
            {

                yourtext.text = "0.06 µSv/h";
                Debug.Log("hit");
            }

            if (hitInfo.collider.name == "cs137")
            {
                 r = Vector3.Distance(this.transform.position, hitInfo.collider.gameObject.transform.position);
                float dose;
                float c = 0.137f;
              
                dose = (2814 * c * Mathf.Exp(-(9 ^(-3)) * r))/(r*r);

                yourtext.text = dose+"µSv/h";

            }

            if (hitInfo.collider.name == "cs60")
            {
                r = Vector3.Distance(this.transform.position, hitInfo.collider.gameObject.transform.position);
                float dose;
                float c = 0.60f;
             //   dose = ((12500 * c) / (r * r));

                dose = (12500 * c * Mathf.Exp(-(7 ^ (-3)) * r)) / (r * r);
               
                yourtext.text = dose + "µSv/h";
            }



            if (hitInfo.collider.name == "combine")
            {
                r = Vector3.Distance(this.transform.position, hitInfo.collider.gameObject.transform.position);
                float dose;
                float c = 0.60f;
                float c1 = 0.137f;
                dose = (2814 * c1 * Mathf.Exp(-(9 ^ (-3)) * r)) / (r * r) + ((2814 * c1 * Mathf.Exp(-(9 ^ (-3)) * r)) / (r * r) / (r * r)) + (12500 * c * Mathf.Exp(-(7 ^ (-3)) * r)) / (r * r);
                yourtext.text = dose + "µSv/h";
            }
        }
        if(!result)
        {
            Invoke("calc", 2f);
        }
    }
    public void Start()
    {
        InvokeRepeating("Raycastsingle", 0.5f,1);
    }

    public void calc()
    {
        float number = Random.Range(0.06f, 0.1f);

        yourtext.text = number.ToString() + "µSv/h";
        if(number > 0.2f)
        {
            source.PlayOneShot(clip);
        }

    }

}