using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Items
{
    Nothing = 0,
    Shovel,
    Chest,
    Ring,
    Cup,
    Monkey,
}

public class PlayerInfo : MonoBehaviour
{
    public GameObject shovelHeldItem;
    public GameObject chestHeldItem;
    public GameObject ringHeldItem;
    public GameObject cupHeldItem;
    public GameObject monkeyHeldItem;

    public bool InRangeOfGrave = false;

    public Items currentHolding;
    public Items CurrentHoldingItem
    {
        get
        {
            return currentHolding;
        }
        set
        {
            OnHoldingItemChanged(currentHolding, value);
            currentHolding = value;
        }
    }

    private void OnHoldingItemChanged(Items previousItem, Items nextItem)
    {
        if (nextItem == Items.Shovel)
        {
            ObjectiveStatic.ObjectivesStatic?.SignalShovelPickedUp();
        }

        ChangeVisibilityOfHeldItem(previousItem, false);
        ChangeVisibilityOfHeldItem(nextItem, true);
    }

    private void ChangeVisibilityOfHeldItem(Items item, bool value)
    {
        switch (item)
        {
            case Items.Shovel:
                shovelHeldItem.SetActive(value);
                break;
            case Items.Chest:
                chestHeldItem.SetActive(value);
                break;
            case Items.Ring:
                ringHeldItem.SetActive(value);
                break;
            case Items.Cup:
                cupHeldItem.SetActive(value);
                break;
            case Items.Monkey:
                monkeyHeldItem.SetActive(value);
                break;
            case Items.Nothing:
            default:
                break;
        }
    }
}
