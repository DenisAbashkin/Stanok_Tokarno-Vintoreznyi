using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    private Camera TheMainCamera;
    public Camera CameraShesterni;
    
    void Start()
    {
        TheMainCamera = GetComponent<Camera>();
        TheMainCamera = Camera.main;
    }

    public void CameraChanger()
    {
        TheMainCamera.enabled = !TheMainCamera.enabled;
        CameraShesterni.enabled = !CameraShesterni.enabled;
    }
   
    void Update()
    {
        
    }
}
