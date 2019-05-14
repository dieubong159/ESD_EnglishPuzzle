using Assets.Script.Test;
using Assets.Script.Test.ModelMapping;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameDataController : MonoBehaviour {

    public static GameDataController Instance;

    string path;
    string jsonString;

    Dictionary<int, QuestionBase[]> allDataQuestionOfGame;

    private void Awake()
    {
        path = Application.streamingAssetsPath + "/data.json";
        Debug.Log(path);
        jsonString = File.ReadAllText(path);
        GameData gameData = JsonUtility.FromJson<GameData>(jsonString);
        Debug.Log(gameData.ToString());

        allDataQuestionOfGame = new Dictionary<int, QuestionBase[]>();
        foreach (Level level in gameData.levels)
        {
            allDataQuestionOfGame.Add(level.level, level.questions);
        }

        Instance = this;
    }

    public QuestionBase[] getQuestionForLevel(int level)
    {
        return allDataQuestionOfGame[level];
    }




    void Start()
    {
        
        

    }
}