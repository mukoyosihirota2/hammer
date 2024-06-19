using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TMP_Text ScoreText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (ScoreText != null)
        {
            ScoreText.text = "Score" + score;

        }
    }
    public void AddScore(int scorePlus)
    {
        score +=scorePlus;
        
    }
}
