using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FINISH_TASK : MonoBehaviour
{
    public GameObject task1;
    public GameObject task2;
    public GameObject task3;

    public GameObject task12;
    public GameObject task22;
    public GameObject task32;

    public TextMeshProUGUI color1;
    public TextMeshProUGUI color2;
    public TextMeshProUGUI color3;
    public TextMeshProUGUI color4;

    private bool isDone;

    // Start is called before the first frame update
    void Start()
    {
        isDone = false;
    }

    void changeColor()
    {
        task1.SetActive(false);
        task2.SetActive(false);
        task3.SetActive(false);
        task12.SetActive(false);
        task22.SetActive(false);
        task32.SetActive(false);

        color1.color = new Color32(87, 87, 87, 114);
        color2.color = new Color32(87, 87, 87, 114);
        color3.color = new Color32(87, 87, 87, 114);
        color4.color = new Color32(87, 87, 87, 114);
    }

    // Update is called once per frame
    void Update()
    {
        if(!isDone && task1.activeSelf && task2.activeSelf && task3.activeSelf)
        {
            isDone = true;
            changeColor();
        }
    }
}
