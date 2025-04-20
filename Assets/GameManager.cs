using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] TMP_Text gameOverText;
    [SerializeField] Button restartButton;

    [SerializeField] int score = 0;                 // Player's score

    void Start()
    {
        //gameOverText.gameObject.SetActive(false);  // Hide Game Over text 
        //restartButton.gameObject.SetActive(false); // Hide restart button 
    }

    void Update()
    {
        // Continuously update the score display
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddScore(int points)
    {
        score += points; // Add points to the score
    }

    public void GameOver()
    {
        //gameOverText.gameObject.SetActive(true);  // Show Game Over text
        //restartButton.gameObject.SetActive(true); // Show Restart button
        gameOverPanel.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene
    }
}
