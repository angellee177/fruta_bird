using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private bool gameOver;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if(instance == null)
        {
            instance = this;
        } else
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOver = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        UIManager.instance.GameStart();
        GameObject.Find("BuildingSpawner").GetComponent<BuildingSpawner>().StartSpawningBuilding();
    }

    public void GameOver()
    {
        gameOver = false;
        GameObject.Find("BuildingSpawner").GetComponent<BuildingSpawner>().StopSpawningBuilding();
        ScoreManagerHandler.instance.StopScore();
        UIManager.instance.GameOver();
    }
}
