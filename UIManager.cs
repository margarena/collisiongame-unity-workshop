using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public TextMeshProUGUI redScoreText;
    public TextMeshProUGUI blueScoreText;

    public int redScore = 0;
    public int blueScore = 0;

    private void Awake()
    {
        Instance = this;

        redScoreText.text = "SCORE: 0";
        blueScoreText.text = "SCORE 0";
    }

    public void ChangeRedScore()
    {
        redScoreText.text = "SCORE: " + redScore.ToString();
    }

    public void ChangeBlueScore()
    {
        blueScoreText.text = "SCORE: " + blueScore.ToString();
    }
}
