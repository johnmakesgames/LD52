using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Items
{
    Nothing = 0,
    Shovel,
}


public class PlayerInfo : MonoBehaviour
{
    public bool InRangeOfGrave = false;

    public Items CurrentHoldingItem = Items.Nothing;
}
