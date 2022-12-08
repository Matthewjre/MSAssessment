using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class bookScript : MonoBehaviour
{
    public BookPages book;
    
    private List<String> pages;

    [SerializeField] public TextMeshProUGUI leftPage;
    [SerializeField] public TextMeshProUGUI rightPage;
    [SerializeField] public TextMeshProUGUI leftPageNumber;
    [SerializeField] public TextMeshProUGUI rightPageNumber;

    private int currentLeftPage = 0;
    private int currentRightPage = 1;

    public bool bookFinished = false;


    // Start is called before the first frame update
    void Start()
    {
       pages = book.pages;
       leftPage.text = pages[0];
       rightPage.text = pages[1];
       leftPageNumber.text = currentLeftPage.ToString();
        rightPageNumber.text = currentRightPage.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void flipPage()
    {
        if(bookFinished)
        {
            leftPage.text = pages[0];
            rightPage.text = pages[1]; 
            currentLeftPage = 0;
            currentRightPage = 1;
            bookFinished = false;
        }
        else if(!bookFinished)
        {
            if(currentLeftPage+2 >= pages.Count)
            {
                leftPage.text = "End of Book";
                bookFinished = true;

            }
            else
            {
                leftPage.text = pages[currentLeftPage+2];
            }

            if(currentRightPage+2 >= pages.Count)
            {
                rightPage.text = "End of Book";
                bookFinished = true;
            }
            else
            {
                rightPage.text = pages[currentRightPage+2];
            }
            currentLeftPage+=2;
            currentRightPage+=2;

        }
        leftPageNumber.text = currentLeftPage.ToString();
        rightPageNumber.text = currentRightPage.ToString();    
    }



}
