using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Butonlar : MonoBehaviour
{
    public Canvas giriscanvas;
    public Canvas deneyoncesicanvas;
    public Canvas basarilarcanvas;

    [SerializeField]bool delete = false;

    private void Start()
    {
        if(PlayerPrefs.GetInt("deneyoncesicanvas") == 1)
        {
            deneyoncesicanvas.gameObject.SetActive(true);
        }
        else
        {
            deneyoncesicanvas.gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("giriscanvas") == 1)
        {
            giriscanvas.gameObject.SetActive(true);
        }
        else
        {
            giriscanvas.gameObject.SetActive(false);
        }

        if (delete)
        {
            resetplayerprefs();
        }
    }

    void resetplayerprefs()
    {
        PlayerPrefs.SetInt("deneyoncesicanvas", 0);
        PlayerPrefs.SetInt("giriscanvas", 1);
    }

    public void baslabuton(){
        giriscanvas.gameObject.SetActive(false);
        deneyoncesicanvas.gameObject.SetActive(true);
        PlayerPrefs.SetInt("deneyoncesicanvas", 1);
        PlayerPrefs.SetInt("giriscanvas", 0);
    }
    
    public void deney1Buton() {
        SceneManager.LoadScene("Deney1");
    
    }
    public void deney2Buton()
    {
        SceneManager.LoadScene("Deney2");

    }
    public void GeriButon()
    {
        giriscanvas.gameObject.SetActive(true);
        deneyoncesicanvas.gameObject.SetActive(false);

        PlayerPrefs.SetInt("deneyoncesicanvas", 0);
        PlayerPrefs.SetInt("giriscanvas", 1);

    }
    public void GeriButon2()
    {
        giriscanvas.gameObject.SetActive(true);
        basarilarcanvas.gameObject.SetActive(false);

    }
    public void basarilarbuton()
    {
        giriscanvas.gameObject.SetActive(false);
        basarilarcanvas.gameObject.SetActive(true);

    }
    
    public void cikis() {
        Application.Quit();    
    
    }

   
}
