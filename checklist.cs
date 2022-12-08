using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class checklist : MonoBehaviour
{
    public TextMeshProUGUI ClipboardTXT;

    
    // Start is called before the first frame update
    void Start()
    {
        ClipboardTXT.text = "TODO\n*Use a spoon to weigh 2g of KClO3\n*Take the KClO3 from the scale to the fume hood\n*Use a spoon to weigh 2g of sugar\n*Take the sugar from the scale to the fume hood\n*Use the eyedropper to add a few drops of sulfuric acid to the powders";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
