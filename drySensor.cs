using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drySensor : MonoBehaviour
{
    [SerializeField] public string compound;

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Spoon")
        {
            col.gameObject.GetComponent<spoonScript>().isEntered = true;
            col.gameObject.GetComponent<spoonScript>().CPDName = compound;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Spoon")
        {
            col.gameObject.GetComponent<spoonScript>().isEntered = false;
        }
    }
}
