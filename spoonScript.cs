using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spoonScript : MonoBehaviour
{
    public GameObject SensorOBJ;

    public GameObject Powder;

    private GameObject otherPowderPrefab;

    public GameObject powderPrefab;

    public Transform powderSpawnLocation;
    public Transform powderAddLocation;

    private bool isSpoonOccupied;

    private bool nonBeakerPowder;

    public bool isActivated = false;

    public bool boutToScoop = false;

    public bool killPWD = false;

    public bool isEntered;

    public GameObject activePowder;

    public string CPDName;

    public bool delay = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addPowder()
    {
 
        if (!Powder.activeSelf)
        {
            if(isEntered && !delay)
            {
                delay = true;
                Powder.SetActive(true);
                activePowder = GameObject.Find(CPDName);
                isSpoonOccupied = true;
                StartCoroutine(scoopDelay());
            }
        }
        else
        {
            Powder.SetActive(false);
            GameObject clonePWD = Instantiate(activePowder, new Vector3(powderSpawnLocation.position.x, powderSpawnLocation.position.y, powderSpawnLocation.position.z), Quaternion.identity);
            isSpoonOccupied = false;
            StartCoroutine(fixDelay());
        }
    }

    public void addNonBeakerPowder()
    {
        delay = false;
        if (!Powder.activeSelf && boutToScoop && !delay)
        {
            delay = true;
            Powder.SetActive(true);
            isSpoonOccupied = true;
            killPWD = true;
            StartCoroutine(scoopDelay());
        }
    }

    public void activate()
    {
        if(!isActivated)
            isActivated = true;
    }

    public void deactivate()
    {
        if(isActivated)
            isActivated = false;
    }

    IEnumerator fixDelay()
    {
        yield return new WaitForSeconds(1);
        boutToScoop = false;
    }

    IEnumerator scoopDelay()
    {
        yield return new WaitForSeconds(1);
        delay = false;
    }



}
