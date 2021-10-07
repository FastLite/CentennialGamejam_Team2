using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Checkpoint : MonoBehaviour
{
    public static Vector3 lastPointReached = Vector3.zero;
    public GameObject cam;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Checkpoint Reached");
            lastPointReached = transform.position;
            other.GetComponent<ThirdPersonMovement>().enabled = true;
            cam.SetActive(true);
        }
    }
}
