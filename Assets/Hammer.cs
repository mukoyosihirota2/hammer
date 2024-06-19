using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hammer : MonoBehaviour
{
    public int scorePlus = 1;
    public float upDistance = 1.0f; 
    public float minInterval = 3.0f; 
    public float maxInterval = 7.0f; 
    
    public float probability = 0.5f; 

    private float timer = 0.0f;
    private float nextInterval;
   
    void Start()
    {
        // 初期の間隔を設定
        SetNextInterval();
    }

    void Update()
    {
       
            // タイマーを更新
            timer += Time.deltaTime;

        // 一定時間が経過したかをチェック
        if (timer >= nextInterval)
        {
            // タイマーをリセット
            timer = 0.0f;

            // 次の間隔を設定
            SetNextInterval();

            // 一定確率で動かす
            if (Random.value < probability)
            {
                MoveObjectMove();
            }
        }
        
    }

    void SetNextInterval()
    {
        // 次の間隔をランダムに設定
        nextInterval = Random.Range(minInterval, maxInterval);
        if (transform.position.y == 0.0f)
        {
            nextInterval = Random.Range(0.5f,1f);
        }
     }

        void MoveObjectMove()
    {
        if (transform.position.y >= 0.0f)
        {
            transform.position += Vector3.up * -upDistance; 
        }
        else if(transform.position.y == 0.0f)
        {
        transform.position += Vector3.up *-upDistance;
        }
        else if (transform.position.y <= 0.0f)
        {
        transform.position += Vector3.up * upDistance;
        }
    }
    public void OnMouseDown()
    {
        if (Time.timeScale != 0f)
        {
            Vector3 currentPosition = transform.position;

            Vector3 newPosition = new Vector3(currentPosition.x, currentPosition.y - 1, currentPosition.z);

            transform.position = newPosition;
            ScoreManager.instance.AddScore(scorePlus);
        }
    }
}
