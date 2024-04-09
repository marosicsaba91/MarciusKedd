using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed, angularSpeed;

    void Update()
    {
        // Forg�s
        Vector3 targetDir = target.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(targetDir);
        transform.rotation = Quaternion.RotateTowards(
            transform.rotation,
            targetRotation,
            angularSpeed * Time.deltaTime);

        // Mozg�s
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
