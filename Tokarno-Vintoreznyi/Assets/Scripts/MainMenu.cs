using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ObzorStankaPressed()
    {                
       SceneManager.LoadScene("StanokScene");        
    }
    public void ExitPressed()
    {
        Application.Quit();
    }
}
