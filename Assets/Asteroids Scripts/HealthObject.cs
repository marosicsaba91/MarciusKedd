using UnityEngine;

public class HealthObject : MonoBehaviour
{
    [SerializeField] int startHp;

    public int currentHp;

    void Start()
    {
        currentHp = startHp;
    }

    void Update()
    {
        if (currentHp <= 0)
            Destroy(gameObject);
    }
}
