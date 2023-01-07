using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Items
{
    Unknown = 0,
    Shovel,
}


public class PickedUpAction : MonoBehaviour
{
    public Items itemType;
    private PlayerInfo playerInfo;
    public PickupTriggerZone pickupTrigger;

    private void Start()
    {
        var players = GameObject.FindGameObjectsWithTag("Player");
        foreach (var player in players)
        {
            if (player.GetComponent<PlayerInfo>() != null)
            {
                playerInfo = player.GetComponent<PlayerInfo>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (pickupTrigger.PlayerInPickupZone)
            {
                OnPickedUp();
            }
        }
    }

    public void OnPickedUp()
    {
        switch (itemType)
        {
            case Items.Shovel:
                playerInfo.HoldingShovel = true;
                break;
            case Items.Unknown:
            default:
                Debug.LogError("Unknown Item Pickup Action");
                break;
        }

        Destroy(this.gameObject);
    }
}
