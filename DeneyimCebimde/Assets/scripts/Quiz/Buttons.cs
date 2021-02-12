using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
 
    public void Next()
    {
        QuestionGenerator.nextQuestion = true;
        AnswersCheck.buttonReset = true;
    }


}
