using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 2f;  // Speed of enemy movement

    void Update()
    {
        // Move the enemy down the screen
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y < -6f)  
        {
            Debug.Log("Enemy passed the screen! GAME OVER.");

            GameManager gameManager = Object.FindFirstObjectByType<GameManager>();
            if (gameManager != null)
            {
                gameManager.GameOver(); // Trigger Game Over
            }

            Destroy(gameObject);
        }
    }
}
