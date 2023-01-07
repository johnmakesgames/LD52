using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShovelVisibility : MonoBehaviour
{
    PlayerInfo playerInfo;

    public GameObject shovelContainer;

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

    // Update is called once per frame
    void Update()
    {
        if (playerInfo.CurrentHoldingItem == Items.Shovel)
        {
            shovelContainer.SetActive(true);
        }
        else 
        {
            shovelContainer.SetActive(false);
        }
    }
}
