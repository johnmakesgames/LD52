using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grave : MonoBehaviour
{
    PlayerInfo playerInfo = null;
    public GameObject itemSpawnLocation;
    public GameObject dirtPileCapsule;
    public GraveDetectionZone digTriggerZone;
    private bool dug;

    public GameObject[] spawnableObjects;
    public int guaranteedSpawn = -1;

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
                if (digTriggerZone.InRangeOfGrave && playerInfo.CurrentHoldingItem == Items.Shovel)
                {
                    Destroy(dirtPileCapsule);
                    dug = true;
                    ObjectiveStatic.ObjectivesStatic?.SignalGraveDug();
                    SpawnLootItem();
                }
            }
        }
    }

    void SpawnLootItem()
    {
        int itemToSpawn = guaranteedSpawn;
        if (guaranteedSpawn == -1)
        {
            itemToSpawn = Random.Range(0, spawnableObjects.Length);
        }

        GameObject instantiated = Instantiate(spawnableObjects[itemToSpawn], itemSpawnLocation.transform.position, Quaternion.identity);
        instantiated.GetComponent<Rigidbody>().AddForce(Vector3.up * 3, ForceMode.Impulse);
    }
}
