using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayerToAlt : MonoBehaviour
{
    public Transform objectFromOG;
    public Transform objectFromAlt;
    public Vector3 whereToTP;
    public int mod = 1;

    public bool atAlt = false;

    private void Start()
    {
        whereToTP = new Vector3(objectFromAlt.position.x - objectFromOG.position.x, objectFromAlt.position.y - objectFromOG.position.y, objectFromAlt.position.z - objectFromOG.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("E"))
        {
                transform.position = new Vector3(transform.position.x + whereToTP.x, transform.position.y , transform.position.z + (whereToTP.z * mod));
                mod *= -1;
                atAlt = !atAlt;
        }
    }
}
