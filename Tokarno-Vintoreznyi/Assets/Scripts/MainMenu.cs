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
    public void UrokPressed()
    {
        SceneManager.LoadScene("MenuObuchenie");
    }
    public void OrganiPressed()
    {
        SceneManager.LoadScene("MenuOrgani");
    }
    public void UpravlenieSupportomPressed()
    {
        SceneManager.LoadScene("UpravlenieSupportom");
    }
    public void UstanovkaPressed()
    {
        SceneManager.LoadScene("UstanovkaScene");
    }
    public void MainMenuPressed()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ExitPressed()
    {
        Application.Quit();
    }
}
