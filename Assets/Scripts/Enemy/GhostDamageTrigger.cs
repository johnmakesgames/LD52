using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostDamageTrigger : MonoBehaviour
{
    float timeSinceSpawn = 0;

    private void Update()
    {
        timeSinceSpawn += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (timeSinceSpawn >= 1)
        {
            if (other.gameObject.tag == "Player" && other.GetComponent<PlayerInfo>() != null)
            {
                other.GetComponent<PlayerInfo>().DoDamage();
            }
        }
    }
}
