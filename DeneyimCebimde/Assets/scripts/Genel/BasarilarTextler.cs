using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BasarilarTextler : MonoBehaviour
{
    public Text puanlarText;
    public Text[] basariOranlariText;
    public Image[] tikler;
    public Sprite[] tikvecarpi;
    

    int baslangicyuzde;
    int girisimciyuzde;
    int tecrubeliyuzde;
    int ustayuzde;
    int bilimadamiyuzde;

    // Update is called once per frame
    void Update()
    {
        baslangicyuzde = (int) ( (Mathf.Clamp(Puan.puan, 0, Puan.baslangicHedef) / Puan.baslangicHedef) * 100);
        girisimciyuzde = (int)((Mathf.Clamp(Puan.puan, 0, Puan.girisimciHedef) / Puan.girisimciHedef) * 100);
        tecrubeliyuzde = (int)((Mathf.Clamp(Puan.puan, 0, Puan.tecrubeliHedef) / Puan.tecrubeliHedef) * 100);
        ustayuzde = (int)((Mathf.Clamp(Puan.puan, 0, Puan.ustaHedef) / Puan.ustaHedef) * 100);
        bilimadamiyuzde =  (int)((Mathf.Clamp(Puan.puan, 0, Puan.bilimAdamiHedef) / Puan.bilimAdamiHedef) * 100);


        puanlarText.text = "TOPLAM DENEYIM PUANI\n" + Puan.puan + "\n \nDENEYIM SEVIYESI\n" + Puan.deneyimSeviyesi;
        basariOranlariText[0].text = Mathf.Clamp(Puan.puan, 0, Puan.baslangicHedef) + " / " + Puan.baslangicHedef + " |  %" + baslangicyuzde;
        basariOranlariText[1].text = Mathf.Clamp(Puan.puan, 0, Puan.girisimciHedef) + " / " + Puan.girisimciHedef + " |  %" + girisimciyuzde;
        basariOranlariText[2].text = Mathf.Clamp(Puan.puan, 0, Puan.tecrubeliHedef) + " / " + Puan.tecrubeliHedef + " |  %" + tecrubeliyuzde;
        basariOranlariText[3].text = Mathf.Clamp(Puan.puan, 0, Puan.ustaHedef) + " / " + Puan.ustaHedef + " |  %" + ustayuzde;
        basariOranlariText[4].text = Mathf.Clamp(Puan.puan, 0, Puan.bilimAdamiHedef) + " / " + Puan.bilimAdamiHedef + " |  %" + bilimadamiyuzde;
        if (baslangicyuzde == 100)
        {
            tikler[0].sprite = tikvecarpi[0];
        }
        else {
            tikler[0].sprite = tikvecarpi[1];
        
        }
        if (girisimciyuzde == 100)
        {
            tikler[1].sprite = tikvecarpi[0];
        }
        else
        {
            tikler[1].sprite = tikvecarpi[1];

        }
        if (tecrubeliyuzde == 100)
        {
            tikler[2].sprite = tikvecarpi[0];
        }
        else
        {
            tikler[2].sprite = tikvecarpi[1];

        }
        if (ustayuzde == 100)
        {
            tikler[3].sprite = tikvecarpi[0];
        }
        else
        {
            tikler[3].sprite = tikvecarpi[1];

        }
        if (bilimadamiyuzde == 100)
        {
            tikler[4].sprite = tikvecarpi[0];
        }
        else
        {
            tikler[4].sprite = tikvecarpi[1];

        }
       
    }
}
