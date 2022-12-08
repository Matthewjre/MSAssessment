using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Obi;

public class TriggerSink : MonoBehaviour
{
    [SerializeField] public GameObject emitter;

    [SerializeField] public GameObject Sensor;

    private ObiEmitter emitterComp;

    private bool overrideSink = false;
     public bool isSinkOn;

    // Start is called before the first frame update
    void Start()
    {
        emitterComp = emitter.GetComponent<ObiEmitter>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!overrideSink)
        {
            isSinkOn = Sensor.GetComponent<SinkSensor>().isEntered;
            if(isSinkOn)
            {
                emitterComp.speed = 1;
            }
            else
            {
                emitterComp.speed = 0;
            }
        }
    }

    IEnumerator keepSinkOnForTime()
    {
        overrideSink = true;
        emitterComp.speed = 1;
        yield return new WaitForSeconds(5);
        emitterComp.speed = 0;
        overrideSink = false;
    }

    public void useSink()
    {
        StartCoroutine(keepSinkOnForTime());
    }

}
