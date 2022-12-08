using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class DisableSocketContent : MonoBehaviour
{

    XRSocketInteractor socket;
    GameObject target;

    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
    }

    public void socketCheck()
    {

        IXRSelectInteractable objName = socket.GetOldestInteractableSelected();

        target = GameObject.Find(objName.transform.name);

        Debug.Log(objName.transform.name + " in socket of " + transform.name);

        target.SetActive(false);
    }
}
