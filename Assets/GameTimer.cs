using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameTimer : MonoBehaviour
{
    public float gameDuration = 60f;
    public TMP_Text TimeText;

    void Update()
    {
       
        gameDuration -= Time.deltaTime;
        if (TimeText != null)
        {
            TimeText.text = "Time" + gameDuration;

        }
        if (gameDuration<=0f)
        {
            gameDuration=0f;
            EndGame();
        }
       
    }

    void EndGame()
    {
        // ƒQ[ƒ€‚ð’âŽ~‚·‚é
        Time.timeScale = 0f;
       
    }
}
