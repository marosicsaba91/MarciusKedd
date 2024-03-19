using UnityEngine;

public class BoolFunctions : MonoBehaviour
{
    void Start()
    {
        bool b1 = true;
        bool b2 = false;

        float a = 12f, b = 33.5f;

        bool aIsHigherThanB = a > b;   // False
        bool aIsLowerThanB = a < b;    // True

        bool isEqual = a == b;     // Egyenkõ-e?      Hamis
        bool inNotEqual = a != b;  // Nem egyenlõ-e?  True

        a = 12; 
        b = 12;

        aIsHigherThanB = a > b;  // F
        aIsLowerThanB = a < b;   // F
        bool aIsHigherThanBOrEqual = a >= b;   // T
        bool aIsLowerThanBOrEqual = a <= b;    // T

        bool equals1 = "Kutya" == "Cica";   // F 
        bool equals2 = "Kutya" == "Kutya";  // T
        bool equals3 = "kutya" == "Kutya";  // F

        // ------------------------------------------

        int ammo = 10;
        bool haveGun = true;

        bool haveAmmo = ammo > 0;
        bool canWeShoot = haveGun && haveAmmo;

        // ------------------------------------------

        bool isOnGround = false;
        bool canAirJump = true;

        bool canJump = isOnGround || canAirJump;

        // -------------------------------------------

        bool isInTheAir = !isOnGround;   // Negálás
    }
}
