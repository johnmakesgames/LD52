using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveStatic
{
    public static Objectives ObjectivesStatic;
}


public class Objectives : MonoBehaviour
{
    private void Start()
    {
        ObjectiveStatic.ObjectivesStatic = this;
    }

    public GameObject shovelPickedUpStrikethrough;
    bool shovelPickupCompleted = false;
    public void SignalShovelPickedUp()
    {
        if (!shovelPickupCompleted)
        {
            shovelPickupCompleted = true;
            shovelPickedUpStrikethrough.SetActive(true);
        }
    }

    public GameObject graveDugStrikethrough;
    bool graveDugComplete = false;
    public void SignalGraveDug()
    {
        if (!graveDugComplete)
        {
            graveDugComplete = true;
            graveDugStrikethrough.SetActive(true);
        }
    }

    public GameObject chestPutInVanStrikethrough;
    bool chestPutInVanComplete = false;
    public void SignalChestPutInVan()
    {
        if (!chestPutInVanComplete)
        {
            chestPutInVanComplete = true;
            chestPutInVanStrikethrough.SetActive(true);
        }
    }

    public GameObject cupPutInVanStrikethrough;
    bool cupPutInVanComplete = false;
    public void SignalCupPutInVan()
    {
        if (!cupPutInVanComplete)
        {
            cupPutInVanComplete = true;
            cupPutInVanStrikethrough.SetActive(true);
        }
    }

    public GameObject ringPutInVanStrikethrough;
    bool ringPutInVanComplete = false;
    public void SignalRingPutInVan()
    {
        if (!ringPutInVanComplete)
        {
            ringPutInVanComplete = true;
            ringPutInVanStrikethrough.SetActive(true);
        }
    }

    public GameObject monkeyPutInVanStrikethrough;
    bool monkeyPutInVanComplete = false;
    public void SignalMonkeyPutInVan()
    {
        if (!monkeyPutInVanComplete)
        {
            monkeyPutInVanComplete = true;
            monkeyPutInVanStrikethrough.SetActive(true);
        }
    }

    public bool IsGameComplete()
    {
        if (!shovelPickupCompleted)
        {
            return false;
        }

        if (!graveDugComplete)
        {
            return false;
        }

        if (!chestPutInVanComplete)
        {
            return false;
        }

        if (!cupPutInVanComplete)
        {
            return false;
        }

        if (!ringPutInVanComplete)
        {
            return false;
        }

        if (!monkeyPutInVanComplete)
        {
            return false;
        }

        return true;
    }
}
