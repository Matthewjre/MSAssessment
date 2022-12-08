using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Obi;


public class TriggerShower : MonoBehaviour
{
    public ObiEmitter emitterComp;

    public void turnOnShower()
    {
        StartCoroutine(shower());
    }

    IEnumerator shower()
    {
        emitterComp.speed = 1.5f;
        yield return new WaitForSeconds(10);
        emitterComp.speed = 0;
    }

}
