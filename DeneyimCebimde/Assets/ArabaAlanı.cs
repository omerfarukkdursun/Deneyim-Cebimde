using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaAlanı : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Deney4Kontrol.secilenAdam == null)
        {
            Deney4Kontrol.secilenAlan = gameObject;
            Deney4Kontrol.secilenAdam = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //if (Deney4Kontrol.secilenAdam != null)
        //{
        //    Deney4Kontrol.secilenAlan = null;
        //    Deney4Kontrol.secilenAdam = null;
        //}
    }

}
