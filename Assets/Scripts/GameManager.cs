using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public TextMeshProUGUI firstPlayerScoreText;
    public TextMeshProUGUI secondPlayerScoreText;
    public int firstPlayerScore = 0;
    public int secondPlayerScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void FirstPlayerScores()
    {
        firstPlayerScore++;
        firstPlayerScoreText.text = firstPlayerScore.ToString();
        ball.ResetPosition();
    }
    
    public void SecondPlayerScores()
    {
        secondPlayerScore++;
        secondPlayerScoreText.text = secondPlayerScore.ToString();
        ball.ResetPosition();
    }

    public void ResetBall()
    {
        
    }
}
