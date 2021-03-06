using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayerToAlt : MonoBehaviour
{
    public AudioSource teleportSource;
    public AudioClip teleportSound;
    public float teleportVolume = 0.5f;
    
    
    public GameObject cam;
    public Transform objectFromOG;
    public Transform objectFromAlt;
    public Vector3 whereToTP;
    public int mod = 1;

    public bool ePress = false;
    public bool atAlt = false;

    public TimeIndicator indi;

    private void Start()
    {
        whereToTP = new Vector3(objectFromAlt.position.x - objectFromOG.position.x, objectFromAlt.position.y - objectFromOG.position.y, objectFromAlt.position.z - objectFromOG.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("E"))
        {
            ePress = true;
            cam.SetActive(false);
            teleportSource.PlayOneShot(teleportSound, teleportVolume);
        }
    }

    private void FixedUpdate()
    {
        if (ePress)
        {
            transform.position = new Vector3(transform.position.x + (whereToTP.x * mod), transform.position.y + (whereToTP.y * mod), transform.position.z + (whereToTP.z * mod));            
            mod *= -1;
            atAlt = !atAlt;
            cam.SetActive(true);
            ePress = false;
            
            if (!atAlt)
            {
                indi.isDimentionA = true;
            } else
            {
                indi.isDimentionA = false;
            }
        }
    }

    public void playerDied()
    {
        cam.SetActive(false);
        atAlt = false;
        mod = 1;
    }

}
