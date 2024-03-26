using Unity.VisualScripting;
using UnityEngine;

public class MyMath : MonoBehaviour
{
    [SerializeField] int number;

    void Start()
    {
        WritePrimes(number);

        Vector2 a = new Vector2(5, 5);
        Vector2 b = Vector2.right;

        float d = Vector2.Distance(a, b);
    }


    float Clamp(float value, float min, float max)
    {
        if (max < min)
        {
            float t = min;
            min = max;
            max = t;
        }

        if (value < min)
            return min;

        if (value > max)
            return max;

        return value;
    }

    float Clamp01(float value)
    {
        return Clamp(value, 0, 1);
    }

    float Floor(float number)
    {
        float remainder = number % 1;
        return number - remainder;
    }

    float Ceil(float number)
    {
        float remainder = number % 1;
        if (remainder == 0)
            return number;

        return number - remainder + 1;
    }

    float Round(float number)
    {
        float remainder = number % 1;

        if (remainder >= 0.5f)    
            return Ceil(number);
        else
            return Floor(number);
    }


    void WritePrimes(int n)
    {
        int counter = 0;

        for (int i = 2; counter < n; i++)
        {
            if (IsPrime(i))
            {
                Debug.Log(i);
                counter++;
            }
        }
    }

    bool IsPrime(int number) 
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    float Distance(Vector2 a, Vector2 b)
    {
        return (a - b).magnitude;
    }

    Vector3 UnitVectorToB(Vector3 a, Vector3 b) 
    {
        Vector3 full = b - a; // nagy

        return full.normalized;  // kicsi
    }

}
