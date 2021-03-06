﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Deney5İpucu : MonoBehaviour
{
    string[] ipucular = { "Suyu buharlaştırmak için ısıtıcının üstüne getir.", "Suyu soğutmak için soğutucunun üstüne getir.", "Buzu sıvı hale getirmek için ısıtıcının üstüne getir." };

    [SerializeField] Text text;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject text2;


    public void showipucu()
    {

        text2.SetActive(false);
        if (ipucular.Length > 0)
        {
            float p = PlayerPrefs.GetFloat("puan");
            p -= 50;
            PlayerPrefs.SetFloat("puan", p);

            panel.SetActive(true);
            text.text = getipucu() + "\nPuan = " + PlayerPrefs.GetFloat("puan");
        }
        else
        {
            text.text = "Başka ipucunuz kalmamıştır!";
        }
    }

    string getipucu()
    {
        int x = UnityEngine.Random.Range(0, ipucular.Length);

        for (int i = 0; i < ipucular.Length; i++)
        {
            if (i == x)
            {
                string s = ipucular[i];
                RemoveAt<string>(ref ipucular, i);
                return s;
            }
        }
        return null;
    }
    public static void RemoveAt<T>(ref T[] arr, int index)
    {
        arr[index] = arr[arr.Length - 1];
        Array.Resize(ref arr, arr.Length - 1);
    }

    public void howtoplay()
    {
        text2.SetActive(false);
        panel.SetActive(true);
        text.text = "Tahtada veriken görevleri yaparak deneyini tamamla ve 300 puan kazan. \n. Zorlandığın yerlerde ipucu isteye basabilirsin ama unutma 3 ipucu hakkın var ve her ipucu 50 puanını siler";

    }
}
