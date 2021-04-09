using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsıtıcıBolgeControl : MonoBehaviour
{
    private GameObject gameController;
    public GameObject duman;
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Buz")
        {
            collision.gameObject.GetComponent<DragandDrop>().enabled = false;
            collision.gameObject.GetComponent<Animator>().SetBool("Start", true);
        }

        if (collision.gameObject.name == "SuBuhar")
        {
            collision.gameObject.GetComponent<DragandDrop>().enabled = false;
            duman.GetComponentInChildren<SpriteRenderer>().enabled = true;
            duman.GetComponent<Animator>().SetBool("Start", true);
            collision.gameObject.GetComponent<Animator>().SetBool("Start", true);
        }
    }
}
