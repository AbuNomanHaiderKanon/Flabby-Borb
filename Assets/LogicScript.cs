using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem; // Add this for the new Input System

public class LogicScript : MonoBehaviour
{
    public int PlayerScore;
    public TextMeshProUGUI ScoreText;
    public GameObject GameOver;
    public bool gameIsOver = false; // Track game over state

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if (!gameIsOver)
        {
            PlayerScore = PlayerScore + scoreToAdd;
            ScoreText.text = PlayerScore.ToString();
        }
    }

    void Update()
    {
        if (gameIsOver && Keyboard.current.rKey.wasPressedThisFrame)
        {
            restartGame();
        }

        // Exit the game when ESC is pressed
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Application.Quit();
        }
    }

    public void restartGame()
    {
        PlayerScore = 0;
        ScoreText.text = PlayerScore.ToString();
        Time.timeScale = 1f; // Unpause the game
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    public void gameOver()
    {
        GameOver.SetActive(true);
        Time.timeScale = 0f; // Pause the game
        gameIsOver = true;
    }
}
