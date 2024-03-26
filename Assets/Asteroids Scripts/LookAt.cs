using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] Transform toLookAt;
    [SerializeField] float speed;
    [SerializeField] float angularSpeed = 360;

    void Update()
    {
        Vector3 self = transform.position;  // Saj�t
        Vector3 other = toLookAt.position;  // M�sik (Amit n�zek)

        Vector3 direction = other - self;
        direction.Normalize();

        if (direction != Vector3.zero)
        {
            Quaternion targetDirection = Quaternion.LookRotation(direction);
            Quaternion currentRotation = transform.rotation;
            transform.rotation = Quaternion.RotateTowards(
                currentRotation, targetDirection, angularSpeed * Time.deltaTime);
        }

        transform.position = Vector3.MoveTowards(self, other, speed * Time.deltaTime);

    }
}
