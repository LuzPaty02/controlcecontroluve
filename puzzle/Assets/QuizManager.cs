using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // Ensure TMPro is included if using TextMeshPro elements

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswer> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public TMPro.TextMeshProUGUI QuestionTxt; // Text component for the question text
    public Image QuestionImg; // Image component for the question image

    private void Start()
    {
        generateQuestion();
    }

    public void correct()
    {
        // When a question is answered correctly, generate a new question and remove the current one
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false; // Initially set all answers as incorrect
            options[i].transform.GetChild(0).GetComponent<Image>().sprite = QnA[currentQuestion].AnswerImages[i]; // Set answer images
            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true; // Set the correct answer
            }
        }
    }

    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count); // Randomly pick a question
            QuestionTxt.text = QnA[currentQuestion].Question; // Set the question text (if still used)
            QuestionImg.sprite = QnA[currentQuestion].QuestionImage; // Set the question image
            SetAnswers();
        }
        else
        {
            Debug.Log("No more questions!");
            // Handle what happens when there are no more questions
        }
    }
}

