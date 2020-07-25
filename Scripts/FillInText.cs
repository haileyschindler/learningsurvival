using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillInText : MonoBehaviour
{
    //public string question;
    public GameObject inputFieldQ1;
    public GameObject inputField11;
    public GameObject inputField12;
    public GameObject inputField13;
    public GameObject textDisplay; //where text recieved is displayed- will mvoe to antoher script
    public GameObject questionNumber;

    public DataContext context = new DataContext();
    int count = 1;

    /*private void Awake()
    {
        Hide();
    }
    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    } */


    public void StoreName()
    {
        //question = inputFieldQ1.GetComponent<Text>().text;
        //textDisplay.GetComponent<Text>().text = "Hi, " + question;

        QuestionObj newQuestion = new QuestionObj();
        newQuestion.Question = inputFieldQ1.GetComponent<Text>().text;
        newQuestion.CorrectAnswer = inputField11.GetComponent<Text>().text;
        newQuestion.WrongAnswer2 = inputField12.GetComponent<Text>().text;
        newQuestion.WrongAnswer3 = inputField13.GetComponent<Text>().text;

        context.questions.Add(newQuestion);

        //clear textboxes
        count++;
        questionNumber.GetComponent<Text>().text = "Question " + count;

        newQuestion.printProperties();


    }

}
