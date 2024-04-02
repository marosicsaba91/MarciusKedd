using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField] float maxSpeed = 5;       // m/s
    [SerializeField] float acceleration = 5;   // m/s^2
    [SerializeField] float angularSpeed = 180;
    [SerializeField] float drag = 0.5f;        // ???

    Vector3 velocity;

    void Update()
    {
        // Input
        float x = Input.GetAxisRaw("Horizontal");

        // Mozg�s
        Vector3 step = velocity * Time.deltaTime;
        transform.position += step;

        // Forgat�s
        transform.Rotate(0, 0, angularSpeed * -x * Time.deltaTime);
    }

    void FixedUpdate()
    {
        // Input
        float y = Input.GetAxisRaw("Vertical");

        // Gyors�t�s
        velocity += transform.up * acceleration * y * Time.fixedDeltaTime;

        // Lass�t�s (K�zegellen�ll�s)
        Vector3 dragVector = -velocity * drag;
        velocity += dragVector * Time.fixedDeltaTime;

        // Max sebess�g
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
    }
}
