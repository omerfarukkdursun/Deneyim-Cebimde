using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ipucu : MonoBehaviour
{
    string[] ipucular= {"Merkür gezegeninin solunda bir gezegen yoktur.", "Dünya, Güneşe en yakın 3. gezegendir." };
   
    [SerializeField] Text text;
    [SerializeField] GameObject panel;


    public void showipucu() {
        float p = PlayerPrefs.GetFloat("puan");
        p -= 50;
        PlayerPrefs.SetFloat("puan", p);

        panel.SetActive(true);
        text.text = getipucu() + "\nPuan = " + PlayerPrefs.GetFloat("puan");
        
    }

    string getipucu() {
        int x = Random.Range(0, ipucular.Length);

        for (int i = 0; i < ipucular.Length; i++)
        {
            if (i == x)
            {
                return ipucular[i];
            }
        }
        return null;
    }

    public void howtoplay()
    {
        panel.SetActive(true);
        text.text ="Gezegenleri Güneşe doğru sırasıyla sıralayın ve ";
    }
}
