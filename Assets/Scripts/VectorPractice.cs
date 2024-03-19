using UnityEngine;

public class VectorPractice : MonoBehaviour
{
    void Start()
    {
        Vector2 v1 = new Vector2(2, 3);
        Vector2 myVector = new(2,3);

        float myX = myVector.x;
        float myY = myVector.y;

        Vector2 myOtherVector = new(4, 9);

        Vector2 summa = myVector + myOtherVector;
        // 6 12
        Vector2 diff = myVector - myOtherVector;
        // -2 -6

        Vector2 mult = 5 * diff;
        // -10 -30
        Vector2 div = summa / 2;
        // 3 6

        float vectorLength = summa.magnitude;
        Vector2 normalized = summa.normalized;

    }
}
