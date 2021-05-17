using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellDone : MonoBehaviour
{
    private float timer;
    private bool results;
    public GameObject canvas;
    
    void Start()
    {
        timer = 0;
        results = false;
        canvas.gameObject.SetActive(false);
    }

    void Update()
    {
        Results();
    }
    private void OnCollisionEnter(Collision collision)
    {
        timer = 2f;
        results = true;
    }

    private void Results()
    {
        if(results)
        {
            timer-=Time.deltaTime;
            if(timer<=0)
            {
                canvas.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
        }

    }
}
