using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mouseclick : MonoBehaviour
{
    public Text myText;
    public string myString;    
    void Start()
    {
        myText = GameObject.Find("DopInfoText").GetComponent<Text>();
        myText.color = Color.clear;

    }
    private void OnMouseDown()
    {
        myText = GameObject.Find("DopInfoText").GetComponent<Text>();
        myText.text = myString;
        myText.color = Color.Lerp(myText.color, Color.white, 1);
    }
}
