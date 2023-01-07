using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropControler : MonoBehaviour
{
    PlayerInfo playerInfo;
    public Transform orientation;
    public GameObject shovelDropItem;

    private void Start()
    {
        playerInfo = this.GetComponent<PlayerInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            switch (playerInfo.CurrentHoldingItem)
            {
                case Items.Shovel:
                    GameObject instantiated = Instantiate(shovelDropItem, this.transform.position + (orientation.forward * 1.5f) + new Vector3(0, 0.5f, 0), Quaternion.identity);
                    instantiated.GetComponent<Rigidbody>().AddForce(orientation.forward * 8, ForceMode.Impulse);
                    playerInfo.CurrentHoldingItem = Items.Nothing;
                    break;
                case Items.Nothing:
                default:
                    break;
            }
        }
    }
}
