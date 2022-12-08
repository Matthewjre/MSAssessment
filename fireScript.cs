using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireScript : MonoBehaviour
{
    public ParticleSystem stickFire;
    public GameObject checkMark;

    private void Start() {
        stickFire.Stop();
    }

    private void OnParticleCollision(GameObject other) {
        if(other.gameObject.name.ToString() == "Burnstick")
        {
            checkMark.SetActive(true);
           StartCoroutine(burnStick());
        }
    }


    IEnumerator burnStick()
    {
        yield return new WaitForSeconds(2);
        stickFire.Play();
        yield return new WaitForSeconds(15);
        stickFire.Stop();
    }
}
