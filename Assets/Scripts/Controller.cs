using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Controller : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private float screenWidthCenter;
    private float lastControllerPoint;
    private bool holdButton;

    // Start is called before the first frame update
    void Start()
    {
        screenWidthCenter = Screen.width/2;
        lastControllerPoint = screenWidthCenter;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerController();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        holdButton = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {   
        lastControllerPoint = Input.mousePosition.x;
        PlayerBehaviour.controllerX=0;
        holdButton = false;
    }
    public void PlayerController()
    {
        if(holdButton)
        {
            if(Input.mousePosition.x>lastControllerPoint)
            {
                PlayerBehaviour.controllerX= 40f;
                lastControllerPoint = Input.mousePosition.x;
            }
            else if(Input.mousePosition.x<lastControllerPoint)
            {
                PlayerBehaviour.controllerX=(-40f);
                lastControllerPoint = Input.mousePosition.x;
            }
            else
            {
                PlayerBehaviour.controllerX = 0;
            }
        }
    }
}
