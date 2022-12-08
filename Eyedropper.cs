using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Obi;

public class Eyedropper : MonoBehaviour
{
    
    public GameObject emitter;

    public ObiEmitter emitterComp;

    public ObiSolver solver;
    
    // Start is called before the first frame update
    void Start()
    {
        emitterComp = emitter.GetComponent<ObiEmitter>();
    }

  
    public void startDropping()
    {
        solver.parameters.gravity = new Vector3(0,-9.81f,0);
        solver.PushSolverParameters();

        if(emitterComp.speed == 0)
        {
            emitterComp.speed = 1;
        }
        else if(emitterComp.speed == 1)
        {
            emitterComp.speed = 0;
        }
    }
}
