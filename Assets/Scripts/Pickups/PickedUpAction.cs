using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            if (pickupTrigger.PlayerInPickupZone && playerInfo.CurrentHoldingItem == Items.Nothing)
            {
                OnPickedUp();
            } 
        }
    }

    public void OnPickedUp()
    {
        playerInfo.CurrentHoldingItem = itemType;
        Destroy(this.gameObject);
    }
}
