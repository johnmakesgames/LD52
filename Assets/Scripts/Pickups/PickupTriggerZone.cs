using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTriggerZone : MonoBehaviour
{
    public bool PlayerInPickupZone;

    private void Start()
    {
        PlayerInPickupZone = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInPickupZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInPickupZone = false;
        }
    }
}
