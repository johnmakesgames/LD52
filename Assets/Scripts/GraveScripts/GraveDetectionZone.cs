using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraveDetectionZone : MonoBehaviour
{
    public bool InRangeOfGrave;

    // Start is called before the first frame update
    void Start()
    {
        InRangeOfGrave = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            InRangeOfGrave = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            InRangeOfGrave = false;
        }
    }
}
