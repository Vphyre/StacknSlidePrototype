using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartnerBehaviour : MonoBehaviour
{
    public string partnerType;
    protected bool canDestroy;
    // Start is called before the first frame update
    void Start()
    {
        canDestroy = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PartnerController()
    {
        if(partnerType=="SpeedUp")
        {
            print(gameObject.name+gameObject.transform.position);
            PlayerBehaviour.partners++;
            if(PlayerBehaviour.partners>=7)
            {
                PlayerBehaviour.partners = 7;
            }
            canDestroy = true;
            Destroy(transform.gameObject);
        }
        else
        {
           PlayerBehaviour.partners--;
           if(PlayerBehaviour.partners<=0)
           {
               PlayerBehaviour.partners = 1;
           }
           canDestroy = true;
           Destroy(transform.gameObject);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(!canDestroy)
        {
            PartnerController();
        }
        
    }

    private void OnCollisionExit(Collision collision)
    {

    }

}
