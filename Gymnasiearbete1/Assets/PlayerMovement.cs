using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

[Header("Movement")]
public float moveSpeed;

public float shiftSpeed;

public Transform orientation;

float horizontalInput;
float verticalInput;

Vector3 moveDirection;

Rigidbody rb;

private void Start()
{
    rb = GetComponent<Rigidbody>();
    rb.freezeRotation = true;
}

private void Update()
{
    MyInput();
}

private void FixedUpdate() {
    MovePlayer();
}

private void MyInput()
{
    horizontalInput = Input.GetAxisRaw("Horizontal");
    verticalInput = Input.GetAxisRaw("Vertical");

    if (Input.GetKeyDown ("left shift"))
        {
            moveSpeed = 30;
        }
    if (Input.GetKeyUp ("left shift"))
    {
        moveSpeed = 15;
    }
    

}

private void MovePlayer()
{
    moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

    rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
}
 void OnTriggerEnter(Collider someObject)
     {
           if (someObject.transform.gameObject.name == "Cube (85)"){
            Destroy(this.gameObject);
           }
     }

}

    // public float speed = .5f;

    // void Update()
    // {
    //     float xDirection = Input.GetAxis("Horizontal");
    //     float zDirection = Input.GetAxis("Vertical");

    //     Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

    //     transform.position += moveDirection * speed;
    // }

