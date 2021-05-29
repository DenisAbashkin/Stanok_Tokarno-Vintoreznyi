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
        SceneManager.LoadScene("UpravlenieSupportom2");
    }
    public void UstanovkaPressed()
    {
        SceneManager.LoadScene("UstanovkaScene");
    }
    public void ZnakomstvoPressed()
    {
        SceneManager.LoadScene("Znakomstvo");
    }
    public void NaznacheniePressed()
    {
        SceneManager.LoadScene("Naznachenie");
    }
    public void SupportPressed()
    {
        SceneManager.LoadScene("Support");
    }
    public void ZadnyaPressed()
    {
        SceneManager.LoadScene("ZadnyaBabka");
    }
    public void PeredBabkaPressed()
    {
        SceneManager.LoadScene("PednyaBabka");
    }
    public void RezezPressed()
    {
        SceneManager.LoadScene("Rezez");
    }
    public void OboznacheniePressed()
    {
        SceneManager.LoadScene("Oboznachenie");
    }
    public void PerednyaBabkaMechPressed()
    {
        SceneManager.LoadScene("PerednyaBabkaVerh");
    }
    public void ZamenaShesterni2Pressed()
    {
        SceneManager.LoadScene("ZamenaShesterni2");
    }
    public void GitaraPressed()
    {
        SceneManager.LoadScene("Smenahesterenok");
    }
    public GameObject Image_Shesterenki;
    public void GoAnimationPressed()
    {
        Image_Shesterenki.gameObject.SetActive(false);        
    }
    public void PosledovatelnostPressed()
    {
        SceneManager.LoadScene("Posledovatelnost");
    }
    public void ZamenaPatronaPressed()
    {
        SceneManager.LoadScene("SmenaPatrona");
    }
    public void TechObslugaPressed()
    {
        SceneManager.LoadScene("MenuTexObsluga");
    }
    public void UpravlenieShpindelem()
    {
        SceneManager.LoadScene("UpravlenieShpindel");
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
