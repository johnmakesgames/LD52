using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPlayerDetectionTrigger : MonoBehaviour
{
    public bool PlayerInDetectionZone;
    public Vector3 lastKnownPlayerPosition;

    // Start is called before the first frame update
    void Start()
    {
        PlayerInDetectionZone = false;
        lastKnownPlayerPosition = new Vector3(0, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && other.GetComponent<PlayerInfo>() != null)
        {
            PlayerInDetectionZone = true;
            lastKnownPlayerPosition = other.transform.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && other.GetComponent<PlayerInfo>() != null)
        {
            PlayerInDetectionZone = false;
            lastKnownPlayerPosition = other.transform.position;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && other.GetComponent<PlayerInfo>() != null)
        {
            lastKnownPlayerPosition = other.transform.position;
        }
    }
}
