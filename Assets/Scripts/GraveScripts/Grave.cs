using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grave : MonoBehaviour
{
    PlayerInfo playerInfo = null;
    public GameObject itemSpawnLocation;
    public GameObject dirtPileCapsule;
    private bool dug;

    // Start is called before the first frame update
    void Start()
    {
        dug = false;

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
        if (!dug)
        {
            if (Input.GetMouseButton(0))
            {
                if (playerInfo.InRangeOfGrave && playerInfo.CurrentHoldingItem == Items.Shovel)
                {
                    Destroy(dirtPileCapsule);
                    dug = true;
                    SpawnLootItem();
                }
            }
        }
    }

    void SpawnLootItem()
    {

    }
}
