using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Deney5Buton : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject winpanel;
    [SerializeField] GameObject bonuspanel;
    [SerializeField] GameObject text;


    public void Geri()
    {
        SceneManager.LoadScene("Menu");
    }

    public void panelKapat()
    {
        text.SetActive(true);
        panel.gameObject.SetActive(false);

    }

    public void Ileri()
    {
        SceneManager.LoadScene("Deney3");
    }

    public void Bonus()
    {
        
        bonuspanel.gameObject.SetActive(true);
        winpanel.gameObject.SetActive(false);
    }

}
