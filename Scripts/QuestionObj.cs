using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test
{
    public Test()
    {
        /*
          hailey is awesome but wants to make sure griffin feels the same way,
          there is only one right answer, obviously because she IS awesome.
          so she creates a question for griffin to answer...
        */

        //a question is composed of the question itself, plus possible answers, so she thinks it up:
        QuestionObj myQuestion = new QuestionObj();
        myQuestion.Question = "Is hailey awesome";
        myQuestion.CorrectAnswer = "yes";
        myQuestion.WrongAnswer2 = "no";
        myQuestion.WrongAnswer3 = "maybe";
        //now we have a question and a set of answers all held in one variable, myQuestion. just like a string or int we can use it wherever we want.
        //instead of passing around 4 seperate strings for each question, it is all packaged nicely for us in one variable


        //say we store this question object somewhere and ask griffin the next day, we would form a question like so using the different properties of the question
        string haileysquestion = "Hey griffin, " + myQuestion.Question + " ? Your options are: " + myQuestion.WrongAnswer3 + ", " + myQuestion.CorrectAnswer + ", " + myQuestion.WrongAnswer2;
        //if we printed 'haileysquestion' it would look like this: "Hey griffin, 'Is hailey awesome?' Your options are: 'maybe', 'no', 'yes'";


        //now griffin answers
        string griffinsanswer = "yes"; //duh ;)


        //now check to see if griffin is correct:
        if (myQuestion.isCorrect(griffinsanswer))
        {
            Debug.Log("Good job!");
        }
        else
        {
            Debug.Log("You stuck");
        }

    }

}

public class QuestionObj
{
    //QUESTION STRING
    public string Question { get; set; }

    //CORRECT ANSWER STRING
    public string CorrectAnswer { get; set; }

    //WRONG ANSWER 1 STRING
    public string WrongAnswer2 { get; set; }

    //WRONG ANSWER 2 STRING
    public string WrongAnswer3 { get; set; }

    //STRING ARRAY OF ALL POSSIBLE ANSWERS
    public string[] PossibleAnswers = new string[3];


    public bool isCorrect(string answer)
    {
        //IS PASSED STRING EQUAL TO THIS CORRECT ANSWER?
        if (answer == CorrectAnswer)
        {
            return true;
        }
        else
        {
            return false;
        }
    }



    //PRINT OUT QUESTION PROPERRTIES
    public void printProperties()
    {
        Debug.Log(this.Question + ", " + this.CorrectAnswer + this.WrongAnswer2 + this.WrongAnswer3);
    }

}