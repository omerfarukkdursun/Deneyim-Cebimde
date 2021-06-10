using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KagitKontrol : MonoBehaviour
{
    public Sprite kirmizi;
    public Sprite sari;
    public Sprite mavi;
    public Sprite yesil;

    void Update()
    {
        
    }

    public void ChangeSprite(string name)
    {
        if (name == "kirmizi")
        {
            GetComponent<SpriteRenderer>().sprite = kirmizi;
        }
        else if (name == "mavi")
        {
            GetComponent<SpriteRenderer>().sprite = mavi;
        }
        else if (name == "sari")
        {
            GetComponent<SpriteRenderer>().sprite = sari;
        }
        else if (name == "yesil")
        {
            GetComponent<SpriteRenderer>().sprite = yesil;
        }
    }
}
