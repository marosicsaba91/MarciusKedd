using UnityEngine;

public class ControlStructures : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(i * i);
        }
    }
}