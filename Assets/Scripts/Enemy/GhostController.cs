using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour
{
    public GhostPlayerDetectionTrigger ghostPlayerDetectionTrigger;
    public float movementSpeed;
    float timeSinceSpawn = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceSpawn += Time.deltaTime;

        if (ghostPlayerDetectionTrigger.PlayerInDetectionZone && timeSinceSpawn > 1)
        {
            Vector3 movementDirection = ghostPlayerDetectionTrigger.lastKnownPlayerPosition - this.transform.position;
            movementDirection.Normalize();
            this.transform.position += movementDirection * (movementSpeed * Time.deltaTime);

            Vector3 f = Vector3.RotateTowards(this.transform.forward, movementDirection, Mathf.PI * 2, 0.0f);
            this.transform.rotation = Quaternion.LookRotation(f);
        }
    }
}
