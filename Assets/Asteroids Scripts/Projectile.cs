using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float lifeTime = 2;
    [SerializeField] int damage = 10;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }


    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        HealthObject healthObject = other.GetComponent<HealthObject>();
        if (healthObject != null) 
        {
            healthObject.currentHp -= damage;
            Destroy(gameObject);
        }
    }

}