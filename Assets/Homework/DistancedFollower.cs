using UnityEngine;

public class DistancedFollower : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float speed;
    [SerializeField] float maxDistance;

    void Update()
    {
        Vector3 distanceV = target.transform.position - transform.position;
        float distance = distanceV.magnitude;

        if (distance > maxDistance)
        {
            Vector3 direction = distanceV / distance;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
