
using UnityEngine;

[System.Serializable]
public class QuestionAndAnswer
{
    public string Question; // The question text (optional if using images only)
    public Sprite QuestionImage; // Image for the question
    public Sprite[] AnswerImages; // Images for the answers
    public int CorrectAnswer; // Index of the correct answer
}