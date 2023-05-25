using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int CoinCount;

    public void PickUpItem()
    {
        CoinCount++;
    }
}
