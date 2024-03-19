using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] float radius;
    [SerializeField] float k, t;

    void OnValidate()
    {
        float pi = Mathf.PI;
        k = 2 * radius * pi;
        t = Mathf.Pow(radius, 2) * pi;       
    }
}
