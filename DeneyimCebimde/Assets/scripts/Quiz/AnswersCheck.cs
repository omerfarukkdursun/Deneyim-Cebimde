using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswersCheck : MonoBehaviour
{
    [SerializeField] Button [] buttons;
    [SerializeField] Text toplampuan;
    [SerializeField] Text artýpuan;

    public static bool buttonReset;
    private void Start()
    {
        toplampuan.text = PlayerPrefs.GetFloat("puan").ToString();
        artýpuan.text = "";
    }



    private void Update()
    {
        if (buttonReset)
        {
            ButtonReset();
            buttonReset = false;
        }
    }

    public void Control(Text text)
    {
        MakeButtonsNotInteractable();
        MakeButtonRed(text);
        MakeButtonGreen(QuestionGenerator.rightAnswer);
        if (QuestionGenerator.Control(text))
        {
            

            PlayerPrefs.SetFloat("puan", PlayerPrefs.GetFloat("puan") + 50);
            toplampuan.text = PlayerPrefs.GetFloat("puan").ToString();
            artýpuan.text = "+50";
        }
        else
        {
            toplampuan.text = PlayerPrefs.GetFloat("puan").ToString();
            artýpuan.text = "+0";
        
        }
    }

    void MakeButtonsNotInteractable()
    {
        foreach (Button b in buttons)
        {
            b.interactable = false;
        }
    }
    void MakeButtonsInteractable()
    {
        foreach (Button b in buttons)
        {
            b.interactable = true;
        }
    }

    void MakeButtonRed(Text text)
    {
        foreach (Button b in buttons)
        {
            if(b.GetComponentInChildren<Text>(true).text == text.text)
            {
                b.GetComponent<Image>().color = Color.red;
                b.GetComponentInChildren<Text>(true).color = Color.white;
            }
        }
    }
    void MakeButtonGreen(string text)
    {
        foreach (Button b in buttons)
        {
            if (b.GetComponentInChildren<Text>(true).text == text)
            {
                b.GetComponent<Image>().color = Color.green;
                b.GetComponentInChildren<Text>(true).color = Color.white;
            }
        }
    }

    void MakeButtonsWhite()
    {
        foreach (Button b in buttons)
        {
            b.GetComponent<Image>().color = Color.white;
            b.GetComponentInChildren<Text>(true).color = Color.black;
        }
    }

    void ButtonReset()
    {
        MakeButtonsInteractable();
        MakeButtonsWhite();
    }


}
