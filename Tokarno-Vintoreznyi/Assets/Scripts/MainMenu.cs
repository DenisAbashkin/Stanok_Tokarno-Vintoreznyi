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
    public void UpravlenieZadnyaPressed()
    {
        SceneManager.LoadScene("UpravlenieZad");
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
    public void OboznachenieRezezPressed()
    {
        SceneManager.LoadScene("OboznachenieRezez");
    }
    public void PerednyaBabkaMechPressed()
    {
        SceneManager.LoadScene("PerednyaBabkaVerh");
    }
    public void ZamenaShesterni2Pressed()
    {
        SceneManager.LoadScene("ZamenaShesterni2");
    }
    public void RezbaPressed()
    {
        SceneManager.LoadScene("Rezba");
    }
    public void Rezba2Pressed()
    {
        SceneManager.LoadScene("Rezba2");
    }
    public void Rezba3Pressed()
    {
        SceneManager.LoadScene("Rezba3");
    }
    public void Rezba4Pressed()
    {
        SceneManager.LoadScene("Rezba4");
    }
    public void Rezba5Pressed()
    {
        SceneManager.LoadScene("Rezba5");
    }
    public void ZagotovkaRezbaPressed()
    {
        SceneManager.LoadScene("ZagotovkaRezba");
    }
    public void ZagotovkaRezba0Pressed()
    {
        SceneManager.LoadScene("ZagotovkaRezba0");
    }
    public void ZagotovkaRezba01Pressed()
    {
        SceneManager.LoadScene("ZagotovkaRezba01");
    }
    public void ZagotovkaRezba02Pressed()
    {
        SceneManager.LoadScene("ZagotovkaRezba02");
    }
    public void ZagotovkaRezba03Pressed()
    {
        SceneManager.LoadScene("ZagotovkaRezba03");
    }
    public void ZagotovkaRezbaPressed1()
    {
        SceneManager.LoadScene("ZagotovkaRezba1");
    }
    public void ZagotovkaRezbaPressed2()
    {
        SceneManager.LoadScene("ZagotovkaRezba2");
    }
    public void ZagotovkaRezbaPressed3()
    {
        SceneManager.LoadScene("ZagotovkaRezba3");
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
