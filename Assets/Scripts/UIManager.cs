using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject gameOverPanel;
    public GameObject startUI;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ScoreManagerHandler.instance.score.ToString();
    }

    public void GameStart()
    {
        startUI.SetActive(false);
    }

    public void GameOver()
    {
        highScoreText.text = "HIGH SCORE:" + PlayerPrefs.GetInt("HighScore").ToString();
        gameOverPanel.SetActive(true);
    }

    public void Replay()
    {
        Debug.Log("Replay button was clicked!");
        SceneManager.LoadScene("level1");
    }

    public void Menu()
    {
        Debug.Log("Menu button was clicked!");
        SceneManager.LoadScene("Menu");
    }
}
