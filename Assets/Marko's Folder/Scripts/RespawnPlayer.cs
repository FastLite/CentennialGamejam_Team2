using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
   
    public void RepawnPlayer() 
    { 
            gameObject.GetComponent<ThirdPersonMovement>().enabled = false;
            transform.position = Checkpoint.lastPointReached;
        
    }
}
