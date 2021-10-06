using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayerToAlt : MonoBehaviour
{
    public Transform objectFromOG;
    public Transform objectFromAlt;
    public Vector3 whereToTP;

    public bool atAlt = false;

    private void Start()
    {
        whereToTP = new Vector3(objectFromAlt.position.x - objectFromOG.position.x, objectFromAlt.position.y - objectFromOG.position.y, objectFromAlt.position.z - objectFromOG.position.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("E"))
        {
            if (atAlt == false)
            {
                gameObject.GetComponent<ThirdPersonMovement>().enabled = false;
                transform.position = new Vector3(transform.position.x + whereToTP.x, transform.position.y + whereToTP.y, transform.position.z + whereToTP.z);
                gameObject.GetComponent<ThirdPersonMovement>().enabled = true;
                atAlt = true;
            }
            else
            {
                gameObject.GetComponent<ThirdPersonMovement>().enabled = false;
                transform.position = new Vector3(transform.position.x - whereToTP.x, transform.position.y - whereToTP.y, transform.position.z - whereToTP.z);
                gameObject.GetComponent<ThirdPersonMovement>().enabled = true;
                atAlt = false;
            }
        }
    }
}
