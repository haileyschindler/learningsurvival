using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DataContext
{

    public List<QuestionObj> questions {get; set;}

    public DataContext()
    {
        this.questions = new List<QuestionObj>();

        QuestionObj question1 = new QuestionObj();
        question1.Question = "Define Lousy";
        question1.CorrectAnswer = "Very Poor or bad";
        question1.WrongAnswer2 = "Super awesome";
        question1.WrongAnswer3 = "A type of bird";
        this.questions.Add(question1);

        QuestionObj question2 = new QuestionObj();
        question2.Question = "Define Scrawny";
        question2.CorrectAnswer = "Overly thin and bony";
        question2.WrongAnswer2 = "Strong";
        question2.WrongAnswer3 = "Heroic";
        this.questions.Add(question2);

        QuestionObj question3 = new QuestionObj();
        question3.Question = "Ostracized";
        question3.CorrectAnswer = "Excluded";
        question3.WrongAnswer2 = "Included";
        question3.WrongAnswer3 = "An animal";
        this.questions.Add(question3);

        QuestionObj question4 = new QuestionObj();
        question4.Question = "Applying";
        question4.CorrectAnswer = "To try";
        question4.WrongAnswer2 = "Quit";
        question4.WrongAnswer3 = "Cry";
        this.questions.Add(question4);

       /*( QuestionObj question5 = new QuestionObj();
        question1.Question = "";
        question1.CorrectAnswer = "";
        question1.WrongAnswer2 = "";
        question1.WrongAnswer3 = "";
        this.questions.Add(question5);

        QuestionObj question6 = new QuestionObj();
        question1.Question = "";
        question1.CorrectAnswer = "";
        question1.WrongAnswer2 = "";
        question1.WrongAnswer3 = "";
        this.questions.Add(question6);

        QuestionObj question7 = new QuestionObj();
        question1.Question = "";
        question1.CorrectAnswer = "";
        question1.WrongAnswer2 = "";
        question1.WrongAnswer3 = "";
        this.questions.Add(question7);*/

    }

}