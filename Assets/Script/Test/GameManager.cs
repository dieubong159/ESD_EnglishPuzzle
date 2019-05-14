using Assets.Script.Test;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class QuestionImageTexture
{
    public string path;
    public Texture image;
}

public class GameManager : MonoBehaviour {

    public static GameManager Instance;
    public List<QuestionImageTexture> listImgaeTextures;

    public AudioClip impact;
    AudioSource audioSource { get { return GetComponent<AudioSource>(); } }

    private void Awake()
    {
        Instance = this;
    }


    // Use this for initialization
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        audioSource.clip = impact;
        audioSource.playOnAwake = false;
    }

    public Texture getTextureImage(string path)
    {
        foreach(QuestionImageTexture texture in listImgaeTextures)
        {
            if (texture.path.Equals(path))
            {
                return texture.image;
            }
        }
        return null;
    }

    public void click1()
    {
        //Debug.Log("Scene2 loading: QuizType1");
        LevelMap.Instance.setUpLevel(1);
    }

    public void click2()
    {
        audioSource.PlayOneShot(impact);
    }
}
