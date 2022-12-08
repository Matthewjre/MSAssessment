using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burnerScript : MonoBehaviour
{
    
    public ParticleSystem fire;


    // Start is called before the first frame update
    void Start()
    {
        fire.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void turnOnFire()
    {
        if(fire.isStopped)
        {
            fire.Play();
        }
        else
        {
            fire.Stop();
        }
    }
}
