using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBehaviour : MonoBehaviour
{
    public float speed;
    public static float controllerX;
    public static int partners;
    public GameObject partnersObj;
    public Vector3 direction;

    void Start()
    {
        controllerX = 0;
        partners = 1;
    }
    void FixedUpdate()
    {
        ConstantForce();
        ShowHidePartners();
    }
    void ConstantForce()
    {
        direction.x = controllerX;
        transform.GetComponent<Rigidbody>().velocity = speed * direction * Time.deltaTime;
    }
    void ShowHidePartners()
    {
        if(partners==1)
        {
            speed = 55f;
            direction.z = 3f;
            partnersObj.transform.GetChild(0).gameObject.SetActive(false);
            partnersObj.transform.GetChild(1).gameObject.SetActive(false);
            partnersObj.transform.GetChild(2).gameObject.SetActive(false);
            partnersObj.transform.GetChild(3).gameObject.SetActive(false);
            partnersObj.transform.GetChild(4).gameObject.SetActive(false);
            partnersObj.transform.GetChild(5).gameObject.SetActive(false);
        }
        else if(partners==2)
        {
            speed = 60f;
            direction.z = 3.2f;
            partnersObj.transform.GetChild(0).gameObject.SetActive(true);
            partnersObj.transform.GetChild(1).gameObject.SetActive(false);
            partnersObj.transform.GetChild(2).gameObject.SetActive(false);
            partnersObj.transform.GetChild(3).gameObject.SetActive(false);
            partnersObj.transform.GetChild(4).gameObject.SetActive(false);
            partnersObj.transform.GetChild(5).gameObject.SetActive(false);
        }
        else if(partners==3)
        {
            speed = 65f;
            direction.z = 3.4f;
            partnersObj.transform.GetChild(0).gameObject.SetActive(true);
            partnersObj.transform.GetChild(1).gameObject.SetActive(true);
            partnersObj.transform.GetChild(2).gameObject.SetActive(false);
            partnersObj.transform.GetChild(3).gameObject.SetActive(false);
            partnersObj.transform.GetChild(4).gameObject.SetActive(false);
            partnersObj.transform.GetChild(5).gameObject.SetActive(false);
        }
        else if(partners==4)
        {
            speed = 70f;
            direction.z = 3.6f;
            partnersObj.transform.GetChild(0).gameObject.SetActive(true);
            partnersObj.transform.GetChild(1).gameObject.SetActive(true);
            partnersObj.transform.GetChild(2).gameObject.SetActive(true);
            partnersObj.transform.GetChild(3).gameObject.SetActive(false);
            partnersObj.transform.GetChild(4).gameObject.SetActive(false);
            partnersObj.transform.GetChild(5).gameObject.SetActive(false);
        }
        else if(partners==5)
        {
            speed = 75f;
            direction.z = 3.8f;
            partnersObj.transform.GetChild(0).gameObject.SetActive(true);
            partnersObj.transform.GetChild(1).gameObject.SetActive(true);
            partnersObj.transform.GetChild(2).gameObject.SetActive(true);
            partnersObj.transform.GetChild(3).gameObject.SetActive(true);
            partnersObj.transform.GetChild(4).gameObject.SetActive(false);
            partnersObj.transform.GetChild(5).gameObject.SetActive(false);
        }
        else if(partners==6)
        {
            speed = 80f;
            direction.z = 4f;
            partnersObj.transform.GetChild(0).gameObject.SetActive(true);
            partnersObj.transform.GetChild(1).gameObject.SetActive(true);
            partnersObj.transform.GetChild(2).gameObject.SetActive(true);
            partnersObj.transform.GetChild(3).gameObject.SetActive(true);
            partnersObj.transform.GetChild(4).gameObject.SetActive(true);
            partnersObj.transform.GetChild(5).gameObject.SetActive(false);
        }
        else if (partners==7)
        {
            speed = 85f;
            direction.z = 4.5f;
            partnersObj.transform.GetChild(0).gameObject.SetActive(true);
            partnersObj.transform.GetChild(1).gameObject.SetActive(true);
            partnersObj.transform.GetChild(2).gameObject.SetActive(true);
            partnersObj.transform.GetChild(3).gameObject.SetActive(true);
            partnersObj.transform.GetChild(4).gameObject.SetActive(true);
            partnersObj.transform.GetChild(5).gameObject.SetActive(true);
        }
    }
}
