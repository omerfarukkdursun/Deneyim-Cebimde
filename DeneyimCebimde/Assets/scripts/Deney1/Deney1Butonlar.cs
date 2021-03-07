﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deney1Butonlar : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject winpanel;
    [SerializeField] GameObject bonuspanel;

    public void Geri()
    {
        SceneManager.LoadScene("Menu");
    }

    public void panelKapat()
    {

        panel.gameObject.SetActive(false);

    }

    public void Ileri()
    {
        SceneManager.LoadScene("Deney2");
    }

    public void Bonus()
    {
        bonuspanel.gameObject.SetActive(true);
        winpanel.gameObject.SetActive(false);
    }

}
