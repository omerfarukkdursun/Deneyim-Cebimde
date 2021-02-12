using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deney1kontrol : MonoBehaviour
{
    [SerializeField]GameObject[] gezegenler;

    [SerializeField] GameObject winPanel;
    [SerializeField] Text winText;

    [SerializeField] Button [] b;

    int count = 0;

   
    bool kontrol() {

        bool kazandin = true;
        for (int i = 0; i < gezegenler.Length; i++)
        {
            
            if (i == gezegenler.Length - 1)
            {
                if (gezegenler[i].transform.position.x < gezegenler[i - 1].transform.position.x)
                {

                    kazandin = false;

                }
            }
            else {
                if (gezegenler[i].transform.position.x > gezegenler[i + 1].transform.position.x)
                {
                    kazandin = false;
                }

            }

           

        }
        return kazandin;
    
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
            winText.text = "KAZANDIN!\nToplam Puan " + PlayerPrefs.GetFloat("puan");
            count++;

            foreach ( Button bx in b)
            {
                bx.interactable = false;
            }
        }
        
    }
}
