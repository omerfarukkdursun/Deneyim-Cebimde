using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Butonlar : MonoBehaviour
{
    public Canvas giriscanvas;
    public Canvas deneyoncesicanvas;
    public Canvas basarilarcanvas;
    private int counter = 0;
    private AudioSource ses1;
    public Button yourButton;
    public Sprite sesClose;
    public Sprite sesOpen;

    [SerializeField]bool delete = false;

    public void Sound()
    {
        ses1 = GameObject.Find("MusicPlayer").GetComponent<AudioSource>();
        Debug.Log("sound");
        if (counter == 0)
        {
            ses1.Stop();
            yourButton.GetComponent<Image>().sprite = sesClose;
            counter++;
        }
        else
        {
            ses1.Play();
            yourButton.GetComponent<Image>().sprite = sesOpen;
            counter = 0;
        }
    }

    private void Start()
    {
        if (GameObject.Find("MusicPlayButton") != null)
        {
            yourButton = GameObject.Find("MusicPlayButton").GetComponent<Button>();
            yourButton.onClick.AddListener(Sound);
        }
            
        if (PlayerPrefs.GetInt("deneyoncesicanvas") == 1)
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
    public void deney3Buton()
    {
        SceneManager.LoadScene("Deney3");

    }
    public void deney4Buton()
    {
        SceneManager.LoadScene("Deney4");

    }
    public void deney5Buton()
    {
        SceneManager.LoadScene("Deney5");

    }
    public void deney6Buton()
    {
        SceneManager.LoadScene("Deney6");

    }
    public void deney7Buton()
    {
        SceneManager.LoadScene("Deney7");

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
