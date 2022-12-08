using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScaleNumberScript : MonoBehaviour
{
    public ScaleTray scaleTray;

    private float numToShow = 0.0f;

    public TextMeshProUGUI scaleNumber;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numToShow = scaleTray.totalWeight;
        scaleNumber.text = numToShow.ToString();
    }
}
