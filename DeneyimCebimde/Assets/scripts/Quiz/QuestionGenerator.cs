using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionGenerator : MonoBehaviour
{
    [SerializeField] Text questionTxt;
    [SerializeField] Text option1Txt;
    [SerializeField] Text option2Txt;
    [SerializeField] Text option3Txt;
    [SerializeField] Text option4Txt;

    [SerializeField] GameObject panel;
    [SerializeField] Button b;

   [SerializeField] Question[] questions;
    Question[] questionsTemp;

    public static string rightAnswer;

    public static bool nextQuestion;

    void Start()
    {
        questionsTemp = questions;
        getSoru();
    }

    void Update()
    {
        if (nextQuestion)
        {
            getSoru();
            nextQuestion = false;
        }
    }

    void getSoru()
    {
        if (questionsTemp.Length <= 1)
        {
            b.GetComponentInChildren<Text>().text = "Menüye Dön";
        }

        if (questionsTemp.Length <= 0)
        {
            SceneManager.LoadScene("Menu");
            return;
        }

        int x = UnityEngine.Random.Range(0, questionsTemp.Length);

        questionTxt.text = questionsTemp[x].question;
        option1Txt.text = questionsTemp[x].option1;
        option2Txt.text = questionsTemp[x].option2;
        option3Txt.text = questionsTemp[x].option3;
        option4Txt.text = questionsTemp[x].option4;
        rightAnswer = questionsTemp[x].rightAnswer;

        RemoveAt<Question>(ref questionsTemp, x);
        
    }

    public static void RemoveAt<T>(ref T[] arr, int index)
    {
        arr[index] = arr[arr.Length - 1];
        Array.Resize(ref arr, arr.Length - 1);
    }

    public static bool Control(Text text)
    {
        if(text.text == rightAnswer)
        {
            return true;
        }
        return false;
    }
}
