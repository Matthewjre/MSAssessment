using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowerSensor : MonoBehaviour
{
    public bool isEntered;
    
    // Start is called before the first frame update
    void Start()
    {
        isEntered = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Human")
        {
            isEntered = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Human")
        {
            isEntered = false;
        }
    }
}
