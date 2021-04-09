using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DondurucuBolgeControl : MonoBehaviour
{
    private GameObject gameController;
    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "SuDondurma")
        {
            collision.gameObject.GetComponent<DragandDrop>().enabled = false;
            collision.gameObject.GetComponent<Animator>().SetBool("Start", true);
        }

    }
}
