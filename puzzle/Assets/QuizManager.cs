using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
     public List<QuestionAndAnswer> QnA;  
     public GameObject[] options;
     public int currentQuestion;

     
public TMPro.TextMeshProUGUI QuestionTxt;

     private void Start() {
          generateQuestion();
     }
     public void correct(){
          generateQuestion();
          QnA.RemoveAt(currentQuestion);

     }
     void SetAnswers ()
     {
         for (int i = 0; i< options.Length; i++) 
         {
          options[i].GetComponent<AnswerScript>().isCorrect=false;
          //options [i].transform.GetChild(0).GetComponent<Text>().text=QnA[currentQuestion].Answer[i];
          //options [i].transform.GetChild(0).GetComponent<AnswerScript.Text>().text=QnA[currentQuestion].Answer[i];
          options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answer[i];
          if (QnA[currentQuestion].CorrectAnswer==i+1)
          {
           options[i].GetComponent<AnswerScript>().isCorrect=true;
          }
         }
     }
     void generateQuestion(){
          currentQuestion= Random.Range(0, QnA.Count);

          QuestionTxt.text=QnA[currentQuestion].Question;

          SetAnswers();

          
     }

}