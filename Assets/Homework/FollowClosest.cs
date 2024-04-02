using UnityEngine;

public class FollowClosest : MonoBehaviour
{
    [SerializeField] Transform target1, target2;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 selfPos = transform.position;
        float d1 = Vector3.Distance(target1.position, selfPos);
        float d2 = Vector3.Distance(target2.position, selfPos);

        //Vector3 targetPosition;
        //if (d1 < d2)
        //    targetPosition = target1.position;
        //else
        //    targetPosition = target2.position;

        Vector3 targetPosition = d1 <= d2 ? target1.position : target2.position;

        transform.position =
            Vector3.MoveTowards(selfPos, targetPosition, speed * Time.deltaTime);
    }



}
