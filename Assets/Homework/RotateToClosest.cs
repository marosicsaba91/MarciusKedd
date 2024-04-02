using UnityEngine;

public class RotateToClosest : MonoBehaviour
{
    [SerializeField] Transform target1, target2;
    [SerializeField] float angularSpeed;

    void Update()
    {
        Vector3 selfPos = transform.position;
        float d1 = Vector3.Distance(target1.position, selfPos);
        float d2 = Vector3.Distance(target2.position, selfPos);

        Vector3 targetPosition = d1 <= d2 ? target1.position : target2.position;
        Vector3 direction = targetPosition - selfPos;

        Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, direction);
        transform.rotation =
            Quaternion.RotateTowards(transform.rotation, targetRotation, angularSpeed * Time.deltaTime);
    }
}
