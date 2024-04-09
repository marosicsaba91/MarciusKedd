using UnityEngine;

public class RotationVisualizer : MonoBehaviour
{
    [SerializeField] float length = 1;

    void OnDrawGizmos()
    {
        Gizmos.matrix = transform.localToWorldMatrix;

        DrawAxis(Vector3.right, Color.red);
        DrawAxis(Vector3.up, Color.green);
        DrawAxis(Vector3.forward, Color.blue);

        Gizmos.matrix = Matrix4x4.identity;
    }

    void DrawAxis(Vector3 dir, Color color)
    {
        Gizmos.color = color;
        Gizmos.DrawLine(dir * length, -dir * length);
        Gizmos.DrawSphere(dir * length, 0.1f * length);
    }
}
