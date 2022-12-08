using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PURPLE_BEAKER : MonoBehaviour
{
    XRSocketInteractor SUGAR_SOCKET;
    XRSocketInteractor KCLO3_SOCKET;
    bool isRunning;

    private IEnumerator coroutine;
    //public Transform beaker;
    // Start is called before the first frame update
    void Start()
    {
        SUGAR_SOCKET = this.transform.Find("SUGAR_SOCKET").GetComponent<XRSocketInteractor>();
        KCLO3_SOCKET = this.transform.Find("KCIO3_SOCKET").GetComponent<XRSocketInteractor>();
        isRunning = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Dump_Contents()
    {
        //coroutine = dump_contents_coroutine();
        if(!isRunning) StartCoroutine(dump_contents_coroutine());
    }

    public void stop_running()
    {
        isRunning = false;
    }

    private IEnumerator dump_contents_coroutine()
    {
        isRunning = true;
        while (isRunning)
        {
            if (Vector3.Dot(transform.up, Vector3.down) > 0)
            {
                SUGAR_SOCKET.enabled = false;
                KCLO3_SOCKET.enabled = false;
            }
            else
            {
                SUGAR_SOCKET.enabled = true;
                KCLO3_SOCKET.enabled = true;
            }
            yield return null;
        }
        yield return 0;
    }
}
