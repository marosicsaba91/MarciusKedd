using UnityEngine;

public class ControlStructures : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i <= 100; i+=2)
        {
            Debug.Log(i);
        }
    }
}