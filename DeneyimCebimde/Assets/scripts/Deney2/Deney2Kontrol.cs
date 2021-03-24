using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deney2Kontrol : MonoBehaviour
{
    [SerializeField] GameObject[] iskelet;

    [SerializeField] GameObject winPanel;
    [SerializeField] Text winText;

    [SerializeField] Button[] b;
    ParticleSystem konfeti;

    int count = 0;
    private int alanCount = 0;

    public void AlanGiris()
    {

        alanCount++;

        if (alanCount == iskelet.Length-1) {
            winPanel.SetActive(true);
            float f = PlayerPrefs.GetFloat("puan") + 300;
            PlayerPrefs.SetFloat("puan", f);
            winText.text = "\nKAZANDIN!\n\n\nToplam Puan " + PlayerPrefs.GetFloat("puan");
            winPanel.GetComponent<Animator>().SetBool("isWin", true);

            foreach (GameObject i in iskelet)
            {
                i.GetComponent<DragandDrop>().enabled = false;
            }

            foreach (Button bx in b)
            {
                bx.interactable = false;
            }
        }

        else
            Debug.Log(alanCount);

    }

    public void AlanCıkıs()
    {
        alanCount--;
        Debug.Log(alanCount);
    }

    bool kontrol()
    {
        /*
        bool kazandin = true;
        for (int i = 0; i < iskelet.Length; i++)
        {

            if (i == iskelet.Length - 1)
            {
                if (iskelet[i].transform.position.x < iskelet[i - 1].transform.position.x)
                {

                    kazandin = false;

                }
            }
            else
            {
                if (iskelet[i].transform.position.x > iskelet[i + 1].transform.position.x)
                {
                    kazandin = false;
                }

            }



        }*/
        //return kazandin;
        return false;
    }
    void konfeti_durdur()
    {

        konfeti.Stop();



    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (kontrol() && count == 0)
        {
            winPanel.SetActive(true);
            float f = PlayerPrefs.GetFloat("puan") + 300;
            PlayerPrefs.SetFloat("puan", f);
            winText.text = "\nKAZANDIN!\n\n\nToplam Puan " + PlayerPrefs.GetFloat("puan");
            count++;
            //konfeti = GameObject.Find("kutlama").GetComponent<ParticleSystem>();
            //Invoke("konfeti_durdur", 5.0f);
            foreach (Button bx in b)
            {
                bx.interactable = false;
            }
        }

    }
}
