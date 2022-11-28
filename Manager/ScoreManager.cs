using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    [Header("Text Variables")]
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text highScoreText;
    [Header("Game Over Text Score")]
    [SerializeField] TMP_Text gameOverScoreText;
    [SerializeField] TMP_Text gameOverHighScoreText;
    public Slider sliderGoal;
    public int score = 0;
    public int scoreCounter;
    private int goalPoints;
    int highScore = 0;

    void Awake()
    {
        instance = this;
        goalPoints = PlayerPrefs.GetInt("goalScore");
    }

    void Update()
    {
        SliderGoal();
    }
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore");
        scoreText.text = score.ToString();
        highScoreText.text = "Highscore: " + highScore.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        scoreCounter++;
        goalPoints++;
        scoreText.text = score.ToString();
        sliderGoal.value++;
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("highscore", score);
        }
        FruitSpawner.instance.Progress();
    }
    public void MinusPoint()
    {
        if (score > 0)
        {
            score -= 1;
            scoreCounter -= 1;
            scoreText.text = score.ToString();
        }
    }
    public void SliderGoal()
    {
        if (sliderGoal.value == sliderGoal.maxValue)
        {
            sliderGoal.maxValue = sliderGoal.maxValue + 50;
            goalPoints = 0;
            sliderGoal.value = goalPoints;
        }
    }
    public void GameOver()
    {
        gameOverScoreText.text = "Score: " + score;
        gameOverHighScoreText.text = "Highscore: " + highScore;
        if (score >= highScore)
        {
            //ToDatabase();
        }
    }
}
