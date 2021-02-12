using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puan : MonoBehaviour
{
    // Start is called before the first frame update
    public static float puan=900;

    public static string deneyimSeviyesi;
    public static float baslangicHedef = 300;
    public static float girisimciHedef = 500;
    public static float tecrubeliHedef = 800;
    public static float ustaHedef = 1200;
    public static float bilimAdamiHedef = 1700;

    public void deneyimSeviyesiBul() {
        if (puan>=0 && puan <= baslangicHedef)
        {
            deneyimSeviyesi = "Baslangic";
            
        }
        else if (puan > baslangicHedef && puan <= girisimciHedef)
        {
            deneyimSeviyesi = "Girisimci";

        }
        else if (puan > girisimciHedef && puan <= tecrubeliHedef)
        {
            deneyimSeviyesi = "Tecrubeli";

        }
        else if (puan > tecrubeliHedef && puan <= ustaHedef)
        {
            deneyimSeviyesi = "Usta";

        }
        else if (puan > ustaHedef && puan <= bilimAdamiHedef)
        {
            deneyimSeviyesi = "Bilim Insani";

        }
    
    }

    // Update is called once per frame
    void Update()
    {
        puan = PlayerPrefs.GetFloat("puan");
        deneyimSeviyesiBul();
    }
}
