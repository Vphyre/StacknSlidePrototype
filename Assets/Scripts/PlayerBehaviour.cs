using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;


public class PlayerBehaviour : MonoBehaviour
{
    public float speed;
    public static float controllerX;
    public static int partners;
    public GameObject partnersObj;
    public Vector3 direction;
    public bool playerCollider;

    void Start()
    {
        controllerX = 0;
        partners = 1;
    }
    void FixedUpdate()
    {
        ConstantForce();
        ShowHidePartners();
        ResetPosition();
    }
    void ConstantForce()
    {
        direction.x = controllerX;
        transform.GetComponent<ConstantForce>().relativeForce = new Vector3(direction.x, direction.y, direction.z);       
    }
    void ShowHidePartners()
    {
        if(partners==1)
        {
            
            transform.parent.GetComponent<SplineFollower>().followSpeed = 0.6f;
            partnersObj.transform.GetChild(0).gameObject.SetActive(false);
            partnersObj.transform.GetChild(1).gameObject.SetActive(false);
            partnersObj.transform.GetChild(2).gameObject.SetActive(false);
            partnersObj.transform.GetChild(3).gameObject.SetActive(false);
            partnersObj.transform.GetChild(4).gameObject.SetActive(false);
            partnersObj.transform.GetChild(5).gameObject.SetActive(false);
        }
        else if(partners==2)
        {
            
            transform.parent.GetComponent<SplineFollower>().followSpeed = 0.8f;
            partnersObj.transform.GetChild(0).gameObject.SetActive(true);
            partnersObj.transform.GetChild(1).gameObject.SetActive(false);
            partnersObj.transform.GetChild(2).gameObject.SetActive(false);
            partnersObj.transform.GetChild(3).gameObject.SetActive(false);
            partnersObj.transform.GetChild(4).gameObject.SetActive(false);
            partnersObj.transform.GetChild(5).gameObject.SetActive(false);
        }
        else if(partners==3)
        {
            
            transform.parent.GetComponent<SplineFollower>().followSpeed = 1f;
            partnersObj.transform.GetChild(0).gameObject.SetActive(true);
            partnersObj.transform.GetChild(1).gameObject.SetActive(true);
            partnersObj.transform.GetChild(2).gameObject.SetActive(false);
            partnersObj.transform.GetChild(3).gameObject.SetActive(false);
            partnersObj.transform.GetChild(4).gameObject.SetActive(false);
            partnersObj.transform.GetChild(5).gameObject.SetActive(false);
        }
        else if(partners==4)
        {
           
            transform.parent.GetComponent<SplineFollower>().followSpeed = 1.2f;
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
            transform.parent.GetComponent<SplineFollower>().followSpeed = 1.4f;
            partnersObj.transform.GetChild(0).gameObject.SetActive(true);
            partnersObj.transform.GetChild(1).gameObject.SetActive(true);
            partnersObj.transform.GetChild(2).gameObject.SetActive(true);
            partnersObj.transform.GetChild(3).gameObject.SetActive(true);
            partnersObj.transform.GetChild(4).gameObject.SetActive(false);
            partnersObj.transform.GetChild(5).gameObject.SetActive(false);
        }
        else if(partners==6)
        {
            transform.parent.GetComponent<SplineFollower>().followSpeed = 1.6f;
            partnersObj.transform.GetChild(0).gameObject.SetActive(true);
            partnersObj.transform.GetChild(1).gameObject.SetActive(true);
            partnersObj.transform.GetChild(2).gameObject.SetActive(true);
            partnersObj.transform.GetChild(3).gameObject.SetActive(true);
            partnersObj.transform.GetChild(4).gameObject.SetActive(true);
            partnersObj.transform.GetChild(5).gameObject.SetActive(false);
        }
        else if (partners==7)
        {
            transform.parent.GetComponent<SplineFollower>().followSpeed = 1.8f;
            partnersObj.transform.GetChild(0).gameObject.SetActive(true);
            partnersObj.transform.GetChild(1).gameObject.SetActive(true);
            partnersObj.transform.GetChild(2).gameObject.SetActive(true);
            partnersObj.transform.GetChild(3).gameObject.SetActive(true);
            partnersObj.transform.GetChild(4).gameObject.SetActive(true);
            partnersObj.transform.GetChild(5).gameObject.SetActive(true);
        }
    }
    public void ResetPosition()
    {
        playerCollider = Physics.Raycast(transform.position, Vector3.down, 0.5f);
        if(!playerCollider)
        {
            transform.localPosition = new Vector3(0,0,0);
        }
    }

    void OnDrawGizmosSelected()
    {
       Gizmos.color = Color.red; 
       Gizmos.DrawLine(transform.position, new Vector3(0,-0.5f,0));
    }
}
