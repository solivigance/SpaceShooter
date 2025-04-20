using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;  // Speed of the projectile

    void Update()
    {
        // Move the projectile upwards
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Projectile collided with: " + collision.gameObject.name);

        Enemy enemy = collision.gameObject.GetComponent<Enemy>();

        if (enemy != null) 
        {
            Debug.Log("Projectile hit enemy: " + collision.gameObject.name);

            Destroy(collision.gameObject);
            Destroy(gameObject);

            GameManager gameManager = Object.FindFirstObjectByType<GameManager>();
            if (gameManager != null)
            {
                gameManager.AddScore(1);  // Add 1 point for destroying the enemy
            }
        }
        else
        {
            Debug.Log("Projectile hit something that is not an enemy: " + collision.gameObject.name);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Projectile collided with: " + collision.gameObject.name);

        Enemy enemy = collision.gameObject.GetComponent<Enemy>();

        if (enemy != null)
        {
            Debug.Log("Projectile hit enemy: " + collision.gameObject.name);

            Destroy(collision.gameObject);
            Destroy(gameObject);

            GameManager gameManager = Object.FindFirstObjectByType<GameManager>();
            if (gameManager != null)
            {
                gameManager.AddScore(1);  // Add 1 point for destroying the enemy
            }
        }
        else
        {
            Debug.Log("Projectile hit something that is not an enemy: " + collision.gameObject.name);
        }
    }
}