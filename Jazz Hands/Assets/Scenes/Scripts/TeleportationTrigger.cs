using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationTrigger : MonoBehaviour
{
    public Transform targetAnchor; // Assign the destination teleport anchor in the Unity inspector
    public CharacterController playerController;

    void OnTriggerEnter(Collider other)
    {
        // Check if the player entered the trigger
        if (other.CompareTag("Player"))
        {
            // Teleport the player to the target location (targetAnchor)
            TeleportPlayer(targetAnchor.position);
        }
    }

    void TeleportPlayer(Vector3 targetPosition)
    {
        // Disable the CharacterController to avoid issues with the teleport
        playerController.enabled = false;

        // Move the player to the target position
        playerController.transform.position = targetPosition;

        // Re-enable the CharacterController
        playerController.enabled = true;
    }
}