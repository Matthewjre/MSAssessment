using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Obi;

public class eyeWash : MonoBehaviour
{
    [SerializeField] public ObiEmitter emitter;

    [SerializeField] public ObiEmitter emitter2;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator keepWashOn()
    {
        emitter.speed = 1;
        emitter2.speed = 1;
        yield return new WaitForSeconds(15);
        emitter.speed = 0;
        emitter2.speed = 0;
    }


    public void useEyewash()
    {
        StartCoroutine(keepWashOn());
    }
}
