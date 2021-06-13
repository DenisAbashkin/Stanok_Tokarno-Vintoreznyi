using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUI : MonoBehaviour
{
    public string myString;
    public string myStringDopInfo;
    public Text myText;
    public Text myText2;
    public float fadeTime;
    public bool displayInfo;
    public GameObject PanelToDisable;

    
    void Start()
    {
        myText = GameObject.Find("Text").GetComponent<Text>();
        myText.color = Color.clear;
        PanelToDisable.SetActive(false);
    }

  
    void Update()
    {
        FadeText();
       
    }

    private void OnMouseOver()
    {
        displayInfo = true;
    }

    private void OnMouseExit()
    {
        displayInfo = false;
    }

    void FadeText()
    {
        if (displayInfo)
        {
            myText.text = myString;
            myText.color = Color.Lerp(myText.color, Color.white, fadeTime * Time.deltaTime);
            if (Input.GetMouseButtonDown(0))
            {
                myText2.text = myStringDopInfo;
                myText2.color = Color.Lerp(myText2.color, Color.black, 10);
                PanelToDisable.SetActive(true);
            }
        }
        else
        {
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }
}
