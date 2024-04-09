using UnityEngine;

[ExecuteAlways]
public class Between : MonoBehaviour
{
    [SerializeField] Transform a, b;
    [SerializeField, Range(0, 1)] float rate;
    [SerializeField] float speed = 10;

    Transform currentTarget;

    void Start()
    {
        SetupPosition();
        currentTarget = a;
    }

    void Update()
    {
        if (!Application.isPlaying)
        {
            SetupPosition();
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, speed * Time.deltaTime);
        if (transform.position == currentTarget.position)
            currentTarget = (currentTarget == a) ? b : a;
    }

    void SetupPosition()
    {
        Vector3 ap = a.position;
        Vector3 bp = b.position;

        transform.position = Vector3.Lerp(ap, bp, rate);
        transform.rotation = Quaternion.Lerp(a.rotation, b.rotation, rate);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.Lerp(Color.red, Color.blue, rate);
        Gizmos.DrawLine(a.position, b.position);
    }
}
