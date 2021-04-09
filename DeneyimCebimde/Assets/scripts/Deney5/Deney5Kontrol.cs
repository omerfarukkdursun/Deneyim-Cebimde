using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Deney5Kontrol : MonoBehaviour
{

    [SerializeField] GameObject winPanel;
    [SerializeField] GameObject buz;
    [SerializeField] GameObject DonanSu;
    [SerializeField] GameObject BuharlaşanSu;

    [SerializeField] Text winText;
    [SerializeField] Text text;


    public int counter = 0;


    private bool isWin = false;

    void Update()
    {
        WinControl();
        
    }

    public void WinControl()
    {
        if (counter == 1)
        {
            text.text = "- Gorev 2 - \n   Buzu Erit";
            DonanSu.SetActive(false);
            buz.SetActive(true);
        }
        else if (counter == 2)
        {
            text.text = "- Gorev 3 - \n   Suyu Buharlaştır";
            buz.SetActive(false);
            BuharlaşanSu.SetActive(true);

        }
        else if (counter == 3)
        {
            text.enabled = false;
            winPanel.SetActive(true);
            isWin = true;
            
            float f = PlayerPrefs.GetFloat("puan") + 300;
            PlayerPrefs.SetFloat("puan", f);
            winText.text = "\nKAZANDIN!\n\n\nToplam Puan " + PlayerPrefs.GetFloat("puan");
            winPanel.GetComponent<Animator>().SetBool("isWin", true);

        }

    }

}
