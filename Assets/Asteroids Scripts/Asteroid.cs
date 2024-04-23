using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] float maxSpeed = 5;
    [SerializeField] float maxAgularSpeed = 90;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = Random.Range(-maxAgularSpeed, maxAgularSpeed);

        Vector2 v = Random.insideUnitCircle * maxSpeed; 
        rb.velocity = v;
    }

    void OnDestroy()
    {
        FindObjectOfType<AsteroidSpawner>().RemoveAsteroid(this);
    }
}