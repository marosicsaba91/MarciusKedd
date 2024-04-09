using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrototype;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newProjectile = Instantiate(projectilePrototype);
            newProjectile.transform.position = transform.position;
            newProjectile.transform.rotation = transform.rotation;
            newProjectile.SetActive(true);
        }        
    }
}
