using UnityEngine;

class MyFirstScript : MonoBehaviour
{
    [SerializeField] float speed;

    void Start()
    {
        Debug.Log("Hello Unity!");
        Debug.Log("I'm " + name);
    }

    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}