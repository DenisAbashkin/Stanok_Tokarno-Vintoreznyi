using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUI3 : MonoBehaviour
{
    public string myString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;

    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("DopInfoText").GetComponent<Text>();
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
        if (Input.GetMouseButtonDown(0))
        {
            if (displayInfo)
            {
                myText.text = myString;
                myText.color = Color.Lerp(myText.color, Color.black, 10);
            }           
        }
    }
}
