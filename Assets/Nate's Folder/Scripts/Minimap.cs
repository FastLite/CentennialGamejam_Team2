using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    //transform variable from player object used to make minimap follow you
    public Transform player;

    private void LateUpdate()
    {
        //sets a Vector3 equal to the players position
        Vector3 newPosition = player.position;

        //makes the Vector3 y position stay the same
        newPosition.y = transform.position.y;

        //make transform.position = newPosition;
        transform.position = newPosition;
    }

}
