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
    ParticleSystem konfeti;

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
    void konfeti_durdur() {

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
            foreach ( Button bx in b)
            {
                bx.interactable = false;
            }
        }
        
    }
}
