using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Checkpoint : MonoBehaviour
{
    public static Vector3 lastPointReached = Vector3.zero;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Checkpoint Reached");
            lastPointReached = transform.position;
            other.GetComponent<ThirdPersonMovement>().enabled = true;
        }
    }
}
