using UnityEngine;

public class TestAddition : MonoBehaviour
{
    [SerializeField] int a = 1, b = 2;
    [SerializeField] string resultText;

    void OnValidate()
    {
        //int summa = a + b;
        //resultText = a + " + " + b + " = " + summa;
        resultText = $"{a} + {b} = {a + b}";
    }
}