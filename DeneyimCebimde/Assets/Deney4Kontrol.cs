using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deney4Kontrol : MonoBehaviour
{

    public static GameObject secilenAlan;
    public static GameObject secilenAdam;
    public static bool check = true;

    [SerializeField] GameObject winPanel;
    [SerializeField] Text winText;
    [SerializeField] Text ivmeText;

    public GameObject araba;

    private bool isWin = false;
    int kassizAdamF = 5;
    int kasliAdamF = 10;
    int ustArabaKg = 2;
    int altArabaKg = 3;

    int kuvvet;
    int agirlik;
    int ivme = 5;


    // Update is called once per frame
    void Update()
    {
        Atama();
        Control();
        WinControl();
    }

    int count;
    public void Control()
    {
        if (kuvvet == (agirlik * ivme) && kuvvet != 0 && agirlik != 0)
        {
            check = false;
            secilenAdam.GetComponent<DragandDrop>().enabled = false;
            if (count == 0)
            {
                secilenAdam.transform.position = new Vector3(-1.25f, -2.5f, 0);
                count++;
            }
            Animator anim = secilenAdam.GetComponent<Animator>();
            anim.SetBool("walk", true);
            YurumeVeArabaHareket();
        }
        else
        {
            Debug.Log("kaybetti");
        }


    }



    public void YurumeVeArabaHareket()
    {
        Vector3 destination = new Vector3(-10f, araba.transform.position.y, araba.transform.position.z);
        Vector3 n = araba.transform.position - destination;
        araba.transform.Translate(n.normalized * Time.deltaTime);
        destination = new Vector3(-10f, secilenAdam.transform.position.y, secilenAdam.transform.position.z);
        secilenAdam.transform.Translate((secilenAdam.transform.position - destination).normalized * Time.deltaTime);
        Camera.main.GetComponent<Animator>().SetBool("start", true);
        secilenAdam.GetComponent<DragandDrop>().enabled = false;
        araba.GetComponent<DragandDrop>().enabled = false;
    }

    public void Atama()
    {
        if (secilenAlan != null && secilenAdam != null)
        {
            string adam = secilenAdam.name;
            string araba = secilenAlan.name;
            Debug.Log(adam);

            if (adam == "KasliAdam")
                kuvvet = kasliAdamF;

            if (adam == "KassizAdam")
                kuvvet = kassizAdamF;

            if (araba == "ustAraba")
                agirlik = ustArabaKg;

            if (araba == "altAraba")
                agirlik = altArabaKg;
        }


    }

    public void WinControl()
    {
        if (secilenAdam != null && !isWin)
        {
            if (secilenAdam.transform.position.x >= 4.8f)
            {
                winPanel.SetActive(true);
                isWin = true;
                float f = PlayerPrefs.GetFloat("puan") + 300;
                PlayerPrefs.SetFloat("puan", f);
                winText.text = "\nKAZANDIN!\n\n\nToplam Puan " + PlayerPrefs.GetFloat("puan");
                winPanel.GetComponent<Animator>().SetBool("isWin", true);
                ivmeText.gameObject.SetActive(false);
            }
        }
    }
}
