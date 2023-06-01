using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform player;
    public float transitionSpeed = 5f;

    private Transform currentRoom;

    private void Start()
    {
        // Find the initial room the player is in
        currentRoom = GetPlayerRoom();
        if (currentRoom != null)
            transform.position = currentRoom.position;
    }

    private void LateUpdate()
    {
        // Check if the player has changed rooms
        Transform newRoom = GetPlayerRoom();
        if (newRoom != null && newRoom != currentRoom)
        {
            currentRoom = newRoom;
            StartCoroutine(MoveToRoom(currentRoom));
        }
    }

    private Transform GetPlayerRoom()
    {
        // Check if the player is colliding with any rooms
        Collider2D[] colliders = Physics2D.OverlapPointAll(player.position);
        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("Room"))
                return collider.transform;
        }

        return null;
    }

    private IEnumerator MoveToRoom(Transform room)
    {
        // Smoothly move the camera to the new room position
        Vector3 targetPosition = new Vector3(room.position.x, room.position.y, transform.position.z);
        while (transform.position != targetPosition)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, transitionSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
