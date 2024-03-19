using UnityEngine;

public class IsPythagorean : MonoBehaviour
{
    [SerializeField] int a, b, c;
    [SerializeField] bool isPythagorean;

    void OnValidate()
    {
        int b1, b2, at;

        at = Mathf.Max(a, b, c);

        if (at == a)
        {
            b1 = b;
            b2 = c;
        }
        else if (at == b)
        {
            b1 = a;
            b2 = c;
        }
        else
        {
            b1 = b;
            b2 = a;
        }

        isPythagorean = b1 * b1 + b2 * b2 == at * at;
    }
}
