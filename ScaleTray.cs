using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScaleTray : MonoBehaviour
{
    public float totalWeight = 0.0f;
    float collider_weight;

    public GameObject checkList;

    private void OnCollisionEnter(Collision other) 
    {
        Rigidbody otherRigidbody = other.gameObject.GetComponent<Rigidbody>();
        totalWeight += otherRigidbody.mass;
        collider_weight = otherRigidbody.mass;
        if (totalWeight == 2.0) checkList.SetActive(true);
    }

    private void OnCollisionStay(Collision other)
    {
        
        Rigidbody otherRigidbody = other.gameObject.GetComponent<Rigidbody>();
        otherRigidbody.WakeUp();
        if (collider_weight != otherRigidbody.mass)
        {
            totalWeight += (otherRigidbody.mass - collider_weight);
        }
    }

    private void OnCollisionExit(Collision other) 
    {
        Rigidbody otherRigidbody = other.gameObject.GetComponent<Rigidbody>();
        totalWeight -= otherRigidbody.mass;      
    }


    public void resetNumber()
    {
        totalWeight = 0.0f;
    }
}
