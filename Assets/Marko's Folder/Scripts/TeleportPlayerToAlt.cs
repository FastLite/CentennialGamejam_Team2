using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayerToAlt : MonoBehaviour
{
    public Transform objectFromOG;
    public Transform objectFromAlt;
    public Transform cam;
    public Vector3 whereToTP;
    public int mod = 1;

    public bool ePress = false;
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
            ePress = true;
        }
    }

    private void FixedUpdate()
    {
        if (ePress)
        {
            transform.position = new Vector3(transform.position.x + (whereToTP.x * mod), transform.position.y + (whereToTP.y * mod), transform.position.z + (whereToTP.z * mod));
            mod *= -1;
            atAlt = !atAlt;
            ePress = false;
        }
    }

}
