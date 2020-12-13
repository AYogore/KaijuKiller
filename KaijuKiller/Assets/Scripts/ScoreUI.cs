using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreUI : MonoBehaviour
{
    
    public static int score;

    [SerializeField]
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        scoreText.SetText($"Score = {score}");
        
    }

    public static void IncrementScore()
    {
        score++; //+1 for now 
    }

    public static void IncrementScore(int scoreValue)
    {
        score += scoreValue;
    }
}
