using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUI10 : MonoBehaviour
{
    public string myString;
    public string myStringDopInfo;
    public Text myText;
    public Text myText2;
    public float fadeTime;
    public bool displayInfo;
    public GameObject PanelToDisable;

    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("Text10").GetComponent<Text>();
        myText.color = Color.clear;

    }

    // Update is called once per frame
    void Update()
    {
        FadeText();
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    Screen.lockCursor = false;
        //}
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
