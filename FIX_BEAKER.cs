using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FIX_BEAKER : MonoBehaviour
{
    bool isRunning;

    private IEnumerator coroutine;
    XRSocketInteractor SUGAR_SOCKET;
    XRSocketInteractor KCLO3_SOCKET;
    float positionY;
    // Start is called before the first frame update
    void Start()
    {
        SUGAR_SOCKET = this.transform.Find("SUGAR_SOCKET").GetComponent<XRSocketInteractor>();
        KCLO3_SOCKET = this.transform.Find("KCIO3_SOCKET").GetComponent<XRSocketInteractor>();
        positionY = transform.position.y;
    }

    public void Dump_Contents()
    {
        positionY = transform.position.y;
        StartCoroutine(dump_contents_coroutine());
    }

    private IEnumerator dump_contents_coroutine()
    {
        float start_positionY = 0;
        float positionY = 0;
        int i = 0;

        if(SUGAR_SOCKET.GetOldestInteractableSelected() != null)
            SUGAR_SOCKET.GetOldestInteractableSelected().transform.GetComponent<BoxCollider>().enabled = false;
        if (KCLO3_SOCKET.GetOldestInteractableSelected() != null)
            KCLO3_SOCKET.GetOldestInteractableSelected().transform.GetComponent<BoxCollider>().enabled = false;
        while (transform.position.y != positionY)
        {
            positionY = transform.position.y;
            yield return new WaitForSeconds(1);
        }
        if (SUGAR_SOCKET.GetOldestInteractableSelected() != null)
            SUGAR_SOCKET.GetOldestInteractableSelected().transform.GetComponent<BoxCollider>().enabled = true;
        if (KCLO3_SOCKET.GetOldestInteractableSelected() != null)
            KCLO3_SOCKET.GetOldestInteractableSelected().transform.GetComponent<BoxCollider>().enabled = true;
        if (Vector3.Dot(transform.up, Vector3.down) < 0)
        {
            transform.GetComponent<Rigidbody>().isKinematic = true;
            transform.GetComponent<MeshCollider>().convex = false;
        }
        yield return 0;
    }
}
