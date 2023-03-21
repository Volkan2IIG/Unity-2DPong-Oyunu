using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public int playerScore { get; private set; }
    public Text playerScoreText;
    public Paddle computerPaddle;
    public int computerScore { get; private set; }
    public Text computerScoreText;
    private void Start()
    {//başlar
        NewGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            NewGame();
        }
    }
    //score 0 başlar
    public void NewGame()
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        StartRound();
    }
    //pozisyon sıfırlama
    public void StartRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }
    //score ekleme
    public void PlayerScores()
    {
        SetPlayerScore(playerScore + 1);
        StartRound();
    }

    public void ComputerScores()
    {
        SetComputerScore(computerScore + 1);
        StartRound();
    }

    private void SetPlayerScore(int score)
    {
        playerScore = score;
        playerScoreText.text = score.ToString();
    }

    private void SetComputerScore(int score)
    {
        computerScore = score;
        computerScoreText.text = score.ToString();
    }

}
