using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purpleFire : MonoBehaviour
{

    public bool touchingSugar = false;

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag.ToString() == "Sugar")
        {
           touchingSugar = true;
        }
    }

    private void OnCollisionExit(Collision other) {
        if(other.gameObject.tag == "Suger")
        {
           touchingSugar = false;
        }
    }
}
