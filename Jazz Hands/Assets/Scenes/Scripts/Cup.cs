using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{
    private Vector3 initialPosition; // To store the initial position of the cup
    private Quaternion initialRotation; // To store the initial rotation of the cup

    void Start()
    {
        // Save the initial position and rotation of the cup
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    // This method is called when something collides with the cup
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object that hit the cup is tagged as "Ball"
        if (collision.gameObject.CompareTag("Ball"))
        {
            DestroyCup();
        }
    }

    void DestroyCup()
    {
        // Disable the cup, simulating destruction
        gameObject.SetActive(false);
    }

    public void ResetCup()
    {
        // Reset the cup's position, rotation, and reactivate it
        transform.position = initialPosition;
        transform.rotation = initialRotation;
        gameObject.SetActive(true);
    }
}