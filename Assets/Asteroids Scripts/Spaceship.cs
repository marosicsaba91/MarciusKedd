using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField] float speed = 5;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 direction = new(x,y);
        direction.Normalize();

        Vector3 step = direction * speed * Time.deltaTime;
        transform.position += step;
    }

}
