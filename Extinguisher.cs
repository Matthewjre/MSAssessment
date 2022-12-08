using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extinguisher : MonoBehaviour
{
    public BurnTrashcan trashScript;
    public ParticleSystem system;
    // Start is called before the first frame update

    void Start()
    {
        system.Stop();
    }

    public void startSpray()
    {
        system.Play();
    }

    public void endSpray()
    {
        system.Stop();
    }

    private void OnParticleCollision(GameObject other) {
        if (other.gameObject.name.ToString() == "Trashcan")
        {
            trashScript.stopBurning();
        }
    }
}
