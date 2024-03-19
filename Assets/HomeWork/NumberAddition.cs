using UnityEngine;


public class NumberAddition : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] int summa;

    void OnValidate()
    {
        summa = 1;
        for (int i = 1; i <= number; i++)
        {
            summa += i;
        }
    }
}
