﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilgisayarMesafeKontrol : MonoBehaviour
{
    public GameObject sporButon;
    // Start is called before the first frame update
    void Start()
    {
        //bilgisayar = transform.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= 2.23 && (transform.position.y >=0 || transform.position.y <= .49))
        {
            sporButon.SetActive(true);
        }
    }
}
