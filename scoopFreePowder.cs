using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Obi;

public class scoopFreePowder : MonoBehaviour
{
    
    [SerializeField] public spoonScript spoon;

    public spoonScript OGSpoon;
    [SerializeField] public spoonScript spareSpoon;

    [SerializeField] public spoonScript otherSpareSpoon;

    [SerializeField] public spoonScript SpareSpoon3;

    [SerializeField] public spoonScript SpareSpoon4;


    private bool powderDelay = false;
    
    // Start is called before the first frame update
    void Start()
    {
        OGSpoon = spoon;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) {
        spoon.boutToScoop = true;
        deletePowder();
    }

    void OnCollisionExit(Collision other) {
        spoon.boutToScoop = false;
        deletePowder();
    }

    public void deletePowder()
    {
        if(spoon.killPWD)
        {
            spoon.killPWD = false;
            this.enabled = false;
            Object.Destroy(this.gameObject);
            spoon.boutToScoop = false;
        }
    }

    public void updateSpoon()
    {
        spoon = spareSpoon;
    }

    public void updateSpoon2()
    {
        spoon = otherSpareSpoon;
    }

    public void updateSpoon3()
    {
        spoon = SpareSpoon3;
    }

    public void updateSpoon4()
    {
        spoon = SpareSpoon4;
    }

    public void backToNormalSpoon()
    {
        spoon = OGSpoon;
    }

}
