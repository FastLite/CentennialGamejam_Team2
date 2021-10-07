using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZoneSript : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Respawned");
            other.GetComponent<RespawnPlayer>().RepawnPlayer();
            other.GetComponent<TeleportPlayerToAlt>().playerDied();
        }
    }
}
