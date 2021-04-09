using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Deney5İpucu : MonoBehaviour
{
    string[] ipucular = { "ipucu1", "ipucu2", "ipucu3", "ipucu4" };

    [SerializeField] Text text;
    [SerializeField] GameObject panel;


    public void showipucu()
    {
        

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
        
        panel.SetActive(true);
        text.text = "Deney2 oynanış";

    }
}
