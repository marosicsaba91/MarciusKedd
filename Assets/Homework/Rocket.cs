using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed, angularSpeed;

    void Update()
    {
        // Forgás
        Vector3 targetDir = target.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(targetDir);
        transform.rotation = Quaternion.RotateTowards(
            transform.rotation,
            targetRotation,
            angularSpeed * Time.deltaTime);

        // Mozgás
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
