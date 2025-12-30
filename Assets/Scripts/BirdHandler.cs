using UnityEngine;

public class BirdHandler : MonoBehaviour
{
    Rigidbody2D rigidBody;
    public float upForce;

    bool started;
    bool gameOver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        started = false;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!started && Input.GetMouseButtonDown(0))
        {
            started = true;

            // change the bird body type from Kinematic to Dynamic/
            rigidBody.bodyType = RigidbodyType2D.Dynamic;   
            GameManager.instance.GameStart();     

            Flap();
        } else if (started && Input.GetMouseButtonDown(0)) {
            Flap();
        }
    }

    void Flap()
    {
        // Reset velocity to zero, so the jump feels consistent
        rigidBody.linearVelocity = Vector2.zero; 
        
        // add initial jump to the bird when game started.
        rigidBody.AddForce(new Vector2(0, upForce));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver = true;
        GameManager.instance.GameOver();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Building")  && !gameOver)
        {
            gameOver = true;
            GameManager.instance.GameOver();
        }

        if (collision.gameObject.CompareTag("ScoreChecker") && !gameOver)
        {
            ScoreManagerHandler.instance.IncrementScore();
        }
    }
}
