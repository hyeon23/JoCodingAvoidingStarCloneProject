using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text scoreText;

    private void Awake()
    {
        GameManager.Score = 0;
        scoreText = GetComponent<Text>();
    }

    void Update()
    {
        scoreText.text = GameManager.Score.ToString();  
    }
}
