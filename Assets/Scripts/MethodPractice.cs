using UnityEngine;

public class MethodPractice : MonoBehaviour
{
    [SerializeField] int x, y;
    [SerializeField] int max;
    [SerializeField] float abs;

    void Start()
    {
        max = Max(x, y);
        abs = AbsoluteValue(x);

        MyFirstMethod(1, 2);
    }

    int Max(int a, int b) 
    {
        int m;
        if (a > b)
            m = a;
        else
            m = b;
        return m;
    }

    float AbsoluteValue(float number) 
    {
        if (number > 0)
            return number;
        else
            return -number;
    }

    void MyFirstMethod(int rows, int columns)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= columns; j++)
            {
                Debug.Log($"{i} * {j} = {i * j}");
            }
        }
    }
}
