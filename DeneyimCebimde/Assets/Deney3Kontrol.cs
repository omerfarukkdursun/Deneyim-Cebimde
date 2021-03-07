using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deney3Kontrol : MonoBehaviour
{
    [SerializeField]Ara ara;
    [SerializeField] GameObject winPanel;
    [SerializeField] Text winText;
    [SerializeField] GameObject sagadam;
    [SerializeField] GameObject soladam;
    int count=0;

    int puan;
    [SerializeField] Text text;


    void Update()
    {
        Iletken_Kontrol();
        Yalitkan_Kontrol();
        GenelKontrol();
        puan = (5 - ara.s.Length) * 100;
        text.text = puan.ToString();
        KazandinKontrol();
    }

    void GenelKontrol()
    {
        if (ara.neyedeydi != "İletkenMaddeler" && ara.neyedeydi != "YalitkanMaddeler")
        {
            Animator anim = sagadam.GetComponent<Animator>();
            Animator anim1 = soladam.GetComponent<Animator>();
            anim.SetBool("carp", false);
            anim1.SetBool("carp", true);
        }
    }

    void Iletken_Kontrol()
    {
        if(ara.neyedeydi == "İletkenMaddeler")
        {
            Animator anim =  sagadam.GetComponent<Animator>();
            Animator anim1 = soladam.GetComponent<Animator>();
            anim.SetBool("carp", true);
            anim1.SetBool("carp", true);
        }
    }

    void Yalitkan_Kontrol()
    {
        if (ara.neyedeydi == "YalitkanMaddeler")
        {
            Animator anim = sagadam.GetComponent<Animator>();
            Animator anim1 = soladam.GetComponent<Animator>();
            anim.SetBool("carp", false);
            anim1.SetBool("carp", false);
        }
    }
    void KazandinKontrol()
    {
        if (puan == 500 && count == 0)
        {
            winPanel.SetActive(true);
            float f = PlayerPrefs.GetFloat("puan") + 300;
            PlayerPrefs.SetFloat("puan", f);
            winText.text = "\nKAZANDIN!\n\n\nToplam Puan " + PlayerPrefs.GetFloat("puan");
            count++;
        }
    }
}
