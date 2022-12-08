using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickFireScript : MonoBehaviour
{
    public GameObject Balloon;
    public ParticleSystem explosion;
    public GameObject checkMark;

    public AudioSource boom;
    
    // Start is called before the first frame update
    void Start()
    {
        explosion.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnParticleCollision(GameObject other) {
        if(other.gameObject.name.ToString() == "Grab Balloon")
        {
            Balloon.SetActive(false);
            explosion.Play();
            boom.Play();
            checkMark.SetActive(false);
        }
    }
}
