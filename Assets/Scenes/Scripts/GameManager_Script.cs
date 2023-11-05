using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_Script : MonoBehaviour
{

    private int playerScore;

    [SerializeField]
    private TextMeshProUGUI score;

    [SerializeField]
    private GameObject gameOverScreen;

    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        score.text = playerScore.ToString();
    }

    public void restartGame()
    {
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }


    private void Start()
    {
        gameOverScreen.SetActive(false);
    }
}
