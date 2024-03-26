using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField] float maxSpeed = 5;
    [SerializeField] float acceleration = 5;
    [SerializeField] float angularSpeed = 180;

    Vector3 velocity;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        velocity += transform.up * acceleration * y * Time.deltaTime;
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

        //if (velocity.magnitude > maxSpeed)
        //{
        //    velocity = velocity.normalized * maxSpeed;
        //}

        // direction.Normalize();

        // Debug.Log("TU: " + transform.up);
        // Debug.Log("VU: " + Vector3.up);

        Vector3 step = velocity * Time.deltaTime;
        transform.position += step;

        transform.Rotate(0, 0, angularSpeed * -x * Time.deltaTime);
    }
}
