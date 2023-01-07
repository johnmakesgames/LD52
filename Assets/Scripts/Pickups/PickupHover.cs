using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupHover : MonoBehaviour
{
    float startY;

    private void Start()
    {
        startY = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = new Vector3(this.transform.position.x, startY + Mathf.Sin(Time.realtimeSinceStartup)/10, this.transform.position.z);
        this.transform.Rotate(new Vector3(0, 10 * Time.deltaTime, 0));
    }
}
