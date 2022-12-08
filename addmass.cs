using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class addmass : MonoBehaviour
{

    public void add_mass()
    {
        GetComponent<Rigidbody>().mass += 1;
    }
    public void sub_mass()
    {
        GetComponent<Rigidbody>().mass -= 1;
    }

}
