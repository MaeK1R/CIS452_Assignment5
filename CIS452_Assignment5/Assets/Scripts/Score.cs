using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;

    private float timer;
    public int score;

    private void Start()
    {
        score = 0;
    }
    private void FixedUpdate()
    {
        ScoreText.text = score.ToString();
    }
    public void IncreaseScore()
    {
        Debug.Log("Increase Score");
        score += 1;
        Debug.Log("Score: " + score);
        ScoreText.text = score.ToString();
    }
    public void DecreaseScore()
    {
        Debug.Log("decrease Score");
        score -= 1;
        ScoreText.text = ("Score: " + score.ToString());
    }
}
