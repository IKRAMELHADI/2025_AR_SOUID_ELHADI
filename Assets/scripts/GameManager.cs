using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;
    public int scoreToWin = 10;
    public float timeLimit = 60f;
    public bool gameStarted = false;
    public bool gameOver = false;

    public GameObject gameOverPanel;
    public TextMeshProUGUI resultText;
    public TextMeshProUGUI timerText;
    public Button startButton;

    private float timeRemaining;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        timeRemaining = timeLimit;
        gameOverPanel.SetActive(false);
        startButton.gameObject.SetActive(true);
    }

    void Update()
    {
        if (gameStarted && !gameOver)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "Temps: " + Mathf.CeilToInt(timeRemaining).ToString();

            if (timeRemaining <= 0)
            {
                EndGame(false);
            }
        }
    }

    public void StartGame()
    {
        gameStarted = true;
        gameOver = false;
        score = 0;
        timeRemaining = timeLimit;
        gameOverPanel.SetActive(false);
        startButton.gameObject.SetActive(false);
    }

    public void AddScore()
    {
        if (gameOver) return;

        score++;

        if (score >= scoreToWin)
        {
            EndGame(true);
        }
    }

    void EndGame(bool won)
    {
        gameOver = true;
        gameStarted = false;
        gameOverPanel.SetActive(true);
        resultText.text = won ? "🏆 Gagné !" : "💥 Perdu...";
    }
}
