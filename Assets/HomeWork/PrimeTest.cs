using UnityEngine;

public class PrimeTest : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] bool isPrime;

    void OnValidate()
    {
        isPrime = true;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
    }
}

