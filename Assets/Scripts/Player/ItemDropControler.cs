using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropControler : MonoBehaviour
{
    PlayerInfo playerInfo;
    public Transform orientation;
    public GameObject shovelDropItem;
    public GameObject chestDropItem;
    public GameObject ringDropItem;
    public GameObject cupDropItem;
    public GameObject monkeyDropItem;

    private void Start()
    {
        playerInfo = this.GetComponent<PlayerInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject itemToSpawn = null;
            float spawnImpulse = 0;
            switch (playerInfo.CurrentHoldingItem)
            {
                case Items.Shovel:
                    itemToSpawn = shovelDropItem;
                    spawnImpulse = 2;
                    break;
                case Items.Chest:
                    itemToSpawn = chestDropItem;
                    spawnImpulse = 1;
                    break;
                case Items.Ring:
                    itemToSpawn = ringDropItem;
                    spawnImpulse = 4;
                    break;
                case Items.Cup:
                    itemToSpawn = cupDropItem;
                    spawnImpulse = 4;
                    break;
                case Items.Monkey:
                    itemToSpawn = monkeyDropItem;
                    spawnImpulse = 1;
                    break;
                case Items.Nothing:
                default:
                    break;
            }

            if (itemToSpawn != null)
            {
                GameObject instantiated = Instantiate(itemToSpawn, this.transform.position + (orientation.forward * 1.5f) + new Vector3(0, 0.5f, 0), Quaternion.identity);
                instantiated.GetComponent<Rigidbody>().AddForce(orientation.forward * spawnImpulse, ForceMode.Impulse);
                playerInfo.CurrentHoldingItem = Items.Nothing;
            }
        }
    }
}
