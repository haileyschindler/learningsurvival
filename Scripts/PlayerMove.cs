using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{

    DataContext context;
    Button correctButton;

    private Text topButtonText;
    // Start is called before the first frame update
    void Start()
    {
        context = GetComponent<DataContext>();
        correctButton = GetComponentInChildren<Text>().text;
        topButtonText = correctButton.GetComponentInChildren<Text>().text = "Test";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowQuestion(int questionNumber)
    {
        QuestionObj question = context.questions[questionNumber-1];
        string correct = question.CorrectAnswer;
        string wrongTwo = question.WrongAnswer2;
        string WrongThree = question.WrongAnswer3;

    }
}
