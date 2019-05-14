using Assets.Script.Test;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class AnswerButton
{
    public Button btnAnswer;
}
public class QuizType1Controller : MonoBehaviour {

    [SerializeField]
    List<AnswerButton> answerButtons;

    [SerializeField]
    Text question;
    [SerializeField]
    RawImage imageQuestion;

    QuestionBase currentQuestion;

    private void Awake()
    {
        currentQuestion = LevelMap.Instance.currentQuestion;
    }

    // Use this for initialization
    void Start () {
        question.text = currentQuestion.question;
        imageQuestion.texture = GameManager.Instance.getTextureImage(currentQuestion.imagePath);
        for(int i = 0; i < answerButtons.Count; i++)
        {
            Button btn = answerButtons[i].btnAnswer;
            AnswerEntity answerEntity = btn.gameObject.AddComponent<AnswerEntity>();
            answerEntity.answer = currentQuestion.answers[i];
            answerEntity.displayContent.text = currentQuestion.answers[i].content;
            btn.onClick.AddListener(() => click(btn));
        }
	}

    void click(Button btn)
    {
        Answer selectedAnswer = btn.GetComponent<AnswerEntity>().answer;
        Debug.Log("Click : " + selectedAnswer.ToString());
        if(LevelMap.Instance.checkSelectedAnswer(selectedAnswer))
        {
            btn.gameObject.GetComponentInChildren<Text>().text = "Correct";
            Button[] buttons = gameObject.GetComponentsInChildren<Button>();
            //Debug.Log(buttons.Length);
            foreach(Button button in buttons)
            {
                button.onClick.RemoveAllListeners();
            }
            btn.onClick.AddListener(() => clickNextQuestion());
        }
    }

    void clickNextQuestion()
    {
        LevelMap.Instance.nextQuestionInLevel();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
