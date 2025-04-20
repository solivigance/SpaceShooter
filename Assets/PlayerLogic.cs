using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] GameObject projectilePrefab;
    void Update()
    {
        // Player Movement
        MovePlayer();

        // Shoot Projectiles when the Spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootProjectile();
        }
    }
    void MovePlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");

        float vertical = Input.GetAxis("Vertical");

        Vector2 moveDirection = new Vector2(horizontal, vertical);

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
    void ShootProjectile()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}
