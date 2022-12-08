using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnTrashcan : MonoBehaviour
{
    public ParticleSystem Fire;
	public Light fireLight;
    public GameObject checkMark;
    public GameObject nextTask;

    private bool touchingKCLO3 = false;
    private bool touchingSugar = false;

    public GameObject firePosition;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag.ToString() == "KCIO3")
            touchingKCLO3 = true;
        if (other.gameObject.tag.ToString() == "Sugar")
            touchingSugar = true;
        
        if(touchingKCLO3 && touchingSugar)
        {
            checkMark.SetActive(false);
            nextTask.SetActive(true);
            StartCoroutine(burnTrash());
            firePosition = other.gameObject;
        }
    }

    IEnumerator burnTrash()
    {
        yield return new WaitForSeconds(1);
        Fire.transform.position = firePosition.transform.position;
        Fire.Play();
    }

    public void stopBurning()
    {
        Fire.Stop();
        fireLight.intensity = 0;
    }
}
