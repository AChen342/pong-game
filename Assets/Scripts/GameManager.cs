using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Text playerScoreText;
    public Text computerScoreText;
    private int _playerScore;
    private int _computerScore;
    public static string loseScreen = "LoseScreen";
    public static string winScreen = "WinScreen";

    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }

    public void ComputerScores()
    {
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
    }

    void Update()
    {

        if(SceneManager.GetActiveScene().name == "PongDM"){
            // For DeathMatch Difficulty
            // Lose
            if(this._computerScore == 1){
                SceneManager.LoadScene(loseScreen);
            
            // Win
            }else if(this._playerScore == 1){
                SceneManager.LoadScene(winScreen);
            }

        }else{
            // For regular difficulties (Easy, Normal, Hard)
            // Lose
            if(this._computerScore == 5){
                SceneManager.LoadScene(loseScreen);
            
            // Win
            }else if(this._playerScore == 5){
                SceneManager.LoadScene(winScreen);

            }
        }
    }
}
