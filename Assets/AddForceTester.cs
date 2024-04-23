using UnityEngine;

public class AddForceTester : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidBody2D;
    [SerializeField] float value;



    void Update()
    {
        bool jump = Input.GetKeyDown(KeyCode.Space);

        if (jump)
            rigidBody2D.velocity += Vector2.up * value; // Sebess�g hozz�ad�s

        if (jump)
            rigidBody2D.velocity += Vector2.up * value / rigidBody2D.mass; // Lend�let v�lto�s

        if (jump)
            rigidBody2D.AddForce(Vector2.up * value, ForceMode2D.Impulse); // Lend�let v�lto�s
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 input = new Vector2(x, y);

        // rigidBody2D.velocity += input * value * Time.deltaTime; // gyorsul�s

        rigidBody2D.velocity += input * value / rigidBody2D.mass * Time.fixedDeltaTime; // er�hat�s
        rigidBody2D.AddForce(input * value, ForceMode2D.Force);
    }
}
