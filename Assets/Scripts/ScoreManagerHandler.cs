using UnityEngine;

public class ScoreManagerHandler : MonoBehaviour
{
    public static ScoreManagerHandler instance;
    public int score;
    
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
        score = 0;   
        PlayerPrefs.SetInt("Score", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        // increment the score
        score++;   
    }

    public void StopScore()
    {
        // set the player score for the first time.
        PlayerPrefs.SetInt("Score", score);
        Debug.Log("Game stop, Score:" + score);

        // currentScore is the highest score.
        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
