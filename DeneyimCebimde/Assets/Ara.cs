using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Ara : MonoBehaviour
{
    public string neyedeydi = "deymedi";

    public string []s = { "Pamuk", "Saman","Petsise", "Tahta", "Bardak"};
    public static void RemoveAt<T>(ref T[] arr, int index)
    {
        arr[index] = arr[arr.Length - 1];
        Array.Resize(ref arr, arr.Length - 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == collision.gameObject.name)
            {
                RemoveAt<string>(ref s, i);
                break;
            }
        }
        neyedeydi = collision.gameObject.transform.parent.gameObject.name;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        neyedeydi = "cikti";
    }

    
}
