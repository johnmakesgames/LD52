using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;
    public Transform orientation;
    Vector3 movementVector;
    Rigidbody rb;
    public GameObject cameraHolder;

    // Start is called before the first frame update
    void Start()
    {
        movementVector = new Vector3(0, 0, 0);
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        cameraHolder.transform.position = new Vector3(this.transform.position.x, cameraHolder.transform.position.y, this.transform.position.z);

        MovementKeyChecks();
    }

    void MovementKeyChecks()
    {
        movementVector = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            movementVector += new Vector3(0, 0, 1);
        }

        if (Input.GetKey(KeyCode.S))
        {
            movementVector += new Vector3(0, 0, -1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            movementVector += new Vector3(-1, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            movementVector += new Vector3(1, 0, 0);
        }

        movementVector.Normalize();
    }

    void FixedUpdate()
    {
        Vector3 movementDirection = orientation.forward * movementVector.z + orientation.right * movementVector.x;
        rb.AddForce(movementDirection * movementSpeed * 10, ForceMode.Force);

        if (movementDirection.magnitude > 0)
        {
            HeadBob();
        }
    }

    float time;
    void HeadBob()
    {
        time += Time.deltaTime;
        cameraHolder.transform.position = this.transform.position + new Vector3(0, Mathf.Sin(time * 10) / 10, 0);
    }
}
