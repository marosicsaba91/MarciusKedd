using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField] KeyCode rightKey = KeyCode.RightArrow;
    [SerializeField] KeyCode leftKey = KeyCode.LeftArrow;
    [SerializeField] KeyCode upKey = KeyCode.UpArrow;
    [SerializeField] KeyCode downKey = KeyCode.DownArrow;
    [SerializeField] float speed = 5;

    Vector3 targetPosition;

    void Start()
    {
        targetPosition = transform.position;
    }


    void Update()
    {
        if (transform.position == targetPosition)
        {
            if (Input.GetKeyDown(rightKey))
                targetPosition += Vector3.right;
            if (Input.GetKeyDown(leftKey))
                targetPosition += Vector3.left;
            if (Input.GetKeyDown(upKey))
                targetPosition += Vector3.up;
            if (Input.GetKeyDown(downKey))
                targetPosition += Vector3.down;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);
        }
    }
}
