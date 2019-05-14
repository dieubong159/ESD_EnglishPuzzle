using Assets.Script.Test;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMap : MonoBehaviour {

    public static LevelMap Instance;

    public int currentLevel;
    public QuestionBase[] questionBases;

    public QuestionBase currentQuestion;

    private void Awake()
    {
        currentLevel = 0;
        Instance = this;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void setUpLevel(int level)
    {
        currentLevel = level;
        questionBases = GameDataController.Instance.getQuestionForLevel(level);
        nextQuestionInLevel();
    }

    public QuestionBase[] deleteIndex(int index)
    {
        QuestionBase[] temp = new QuestionBase[questionBases.Length - 1];
        int k = 0;
        for(int i = 0; i < questionBases.Length; i++)
        {
            if(i != index)
            {
                temp[k] = questionBases[i];
                k++;
            }
        }
        return temp;
    }

    public bool checkSelectedAnswer(Answer answer)
    {
        return currentQuestion.result.Equals(answer);
    }

    public void nextQuestionInLevel()
    {
        int index = getIndex();
        Debug.Log("Current question index : " + index + " | Level : " + currentLevel);
        currentQuestion = questionBases[index];
        questionBases = deleteIndex(index);
        loadNextQuestionScene();
    }

    public void loadNextQuestionScene()
    {
        SceneManager.LoadScene(currentQuestion.type);
    }



    private int getIndex()
    {
        return Random.Range(0, questionBases.Length);
    }
}
