using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicManager : MonoBehaviour
{
    public int currentScore = 0;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScene;
    public void addScore(int score)
    {
        currentScore += score;
        scoreText.text = currentScore.ToString();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        gameOverScene.SetActive(true);
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
