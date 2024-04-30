using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stretch : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float effect;

    Vector3 scale;
    void Start()
    {
        scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = this.scale;
        scale.x *= 1 + (effect * Mathf.Sin(Time.time * speed) * 0.5f);
        transform.localScale = scale;
    }
}
