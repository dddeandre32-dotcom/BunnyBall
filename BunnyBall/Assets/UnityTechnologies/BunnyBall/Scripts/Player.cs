using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public Transform cameraTransform;
    public GameManager gameManager;
     int x = 0;
    public int Speed = 50;
public int jumpforce = 400;

    void Update()
    {
        x = x + 1;
            Debug.Log("Hello"+x);
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;
        forward.y = 0;
        right.y = 0;
        forward.Normalize();
        right.Normalize();
        Vector3 direction = forward * moveVertical + right * moveHorizontal;
        rb.AddForce(direction * Speed);

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
              Debug.Log("Space was pressed");
              rb.AddForce(Vector3.up * jumpforce);
        }
    }
}
