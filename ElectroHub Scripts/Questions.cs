using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class Questions : MonoBehaviour
{
    public GameObject AnswerField;
    public GameObject CoinChecker;
    public Text AnswerText;
    public Text QuestionText;
    public int Counter;
    public bool CantChange;

    void Start()
    {
        CantChange = false;
        NextQuestion();
        Counter = 0;
    }
    public void DisplayAnswer()
    {
        
        AnswerField.SetActive(true);
        CoinChecker.SetActive(true);
        
    }
    public void NextQuestion()
    {
        string[] lines = File.ReadAllLines("Questions.txt");
        QuestionText.text = lines[Counter];
        Counter++;
        AnswerText.text = lines[Counter];
        Counter++;
        AnswerField.SetActive(false);
        CoinChecker.SetActive(false);
        FindObjectOfType<Scoremanager>().Flag();
        if (Counter == lines.Length)
        {
            FindObjectOfType<Completed>().CompletedTopic();
        }

    }
}
