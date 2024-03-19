using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class VampireMerchant : MonoBehaviour
{
    [SerializeField] int gold = 10;
    [SerializeField] int hp = 50;

    [SerializeField] bool canBuyBuzogány;
    [SerializeField] bool canBuyTõr;
    [SerializeField] bool canBuyFog;

    void OnValidate()
    {
        canBuyBuzogány = CanPay(15);         
        canBuyTõr = CanPay(4);
        canBuyFog = CanPay(13);
    }

    bool CanPay(int price) 
    {
        float conversion = 5;
        bool canBuyOnGold = gold >= price;
        bool canBuyOnBlood = hp > price;
        return canBuyOnGold || canBuyOnBlood;
    }
}
