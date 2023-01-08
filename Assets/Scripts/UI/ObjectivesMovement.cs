using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivesMovement : MonoBehaviour
{

    public float minY;
    public float maxY;


    // Update is called once per frame
    void Update()
    {
        this.GetComponent<RectTransform>().position += new Vector3(0, (Input.mouseScrollDelta.y * 5000)* Time.deltaTime, 0);
        
        if (this.GetComponent<RectTransform>().position.y < minY)
        {
            this.GetComponent<RectTransform>().position = new Vector3(this.GetComponent<RectTransform>().position.x, minY, this.GetComponent<RectTransform>().position.z);
        }
        else if (this.GetComponent<RectTransform>().position.y > maxY)
        {
            this.GetComponent<RectTransform>().position = new Vector3(this.GetComponent<RectTransform>().position.x, maxY, this.GetComponent<RectTransform>().position.z);
        }
    }
}
