using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deney6Kontrol : MonoBehaviour
{

    public GameObject adam;
    public Button sporButon;
    public GameObject yemekButton;
    public Button yemekButon;


    void Start()
    {
        Button btn = sporButon.GetComponent<Button>();
        btn.onClick.AddListener(SporYapButon);

        Button btn2 = yemekButon.GetComponent<Button>();
        btn2.onClick.AddListener(YemekButon);
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    public void AnimasyonDegis()
    {
    }

    public void SporYapButon()
    {
        adam.GetComponent<Animator>().enabled = true;
        adam.GetComponent<Animator>().SetBool("kalk", true);
        yemekButton.SetActive(true);
    }

    public void YemekButon()
    {
        adam.GetComponent<Animator>().enabled = true;
        adam.GetComponent<Animator>().SetBool("yemek", true);
    }

    public void CloseButtons()
    {
        //yemekButton.SetActive(false);
       // adam.SetActive(false);
        
    }
}
