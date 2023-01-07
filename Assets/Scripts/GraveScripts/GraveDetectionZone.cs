using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraveDetectionZone : MonoBehaviour
{
    PlayerInfo playerInfo;

    // Start is called before the first frame update
    void Start()
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerInfo.InRangeOfGrave = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerInfo.InRangeOfGrave = false;
        }
    }
}
